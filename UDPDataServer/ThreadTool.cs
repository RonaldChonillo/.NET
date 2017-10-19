using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace System.Threading
{
    public delegate void ChangeObjectProperty(Object objTarget, object[] objParams);
    public delegate void CallMethod(Object control, string NameMethod, object[] objParams);

    public class ThreadTool: UserControl
    {
        private ChangeObjectProperty m_ChangeObjectProperty;
        private CallMethod m_CallMethod;

        private System.Windows.Forms.Control m_TargetForm;

        public System.Windows.Forms.Control _TargetForm
        {
            set { m_TargetForm = value; }
            get { return m_TargetForm; }
        }

        public ThreadTool()
        {
            FixObjects();
        }

        public ThreadTool(System.Windows.Forms.Form TargetForm)
        {
            m_TargetForm = TargetForm;
            FixObjects();
        }

        public void FixObjects()
        {
            if (m_ChangeObjectProperty == null)
                m_ChangeObjectProperty = new ChangeObjectProperty(LChangeObjectProperty);
            if(m_CallMethod==null)
                m_CallMethod = new CallMethod(LCallMethod);
        }

        public void InvokeCallMethod(Object objTarget, string NameMethod, object[] objParams)
        {
            if (m_TargetForm != null)
                m_TargetForm.Invoke(this.m_CallMethod,
                        new Object[]
                        { 
                            objTarget,
                            NameMethod,
                            objParams
                        }
                       );
        }

        private void LCallMethod(Object control, string NameMethod, object[] objParams)
        {
           
            Type controlType = control.GetType();

            //
            object[] parametros=null;
            Type[] type = new Type[0];

            if (objParams != null)
            {
                if (objParams.Length > 0)
                {
                    int sizex = objParams.Length;
                    parametros = new object[sizex];
                    type = new Type[sizex];

                    int Index = 0;
                    foreach(object obj in objParams)
                    {
                        Type objtype = obj.GetType();
                        type[Index] = objtype;

                        parametros[Index] = obj;
                        Index++;
                    }
                }
            }

            MethodInfo met = controlType.GetMethod(NameMethod, type);
            met.Invoke(control, parametros);
            
        }

        public void InvokeChangeObjectProperty(Object objTarget, object[] objParams)
        {
            if (m_TargetForm != null)
                m_TargetForm.Invoke(this.m_ChangeObjectProperty,
                        new Object[]
                        { 
                            objTarget,
                            objParams
                        }
                       );
        }

        private void LChangeObjectProperty(Object control, object[] objParams)
        {
            if (objParams[0] == null || objParams[0].ToString() == string.Empty) return;
            if (objParams[1] == null) return;
            
            Type controlType = control.GetType();
            
            //MethodInfo met = controlType.GetMethod("BeginUpdate");
            //met.Invoke(control, new object[] { });
            
            //EventInfo ef = controlType.GetEvent("SelectedIndexChanged");
            //ef.AddEventHandler(this, new EventHandler(ciertoMetodo));

            //PropertyInfo prop = controlType.GetProperty("Items");
            //IList col = (IList)prop.GetValue(control, null);
            //col.Add("Default");
            //col.Add("Auto");

            //prop = controlType.GetProperty("Text");
            //prop.SetValue(control, "Default", null);

            //prop = controlType.GetProperty("Sorted");
            //prop.SetValue(control, true, null);

            //met = controlType.GetMethod("EndUpdate");
            //met.Invoke(control, new object[] { });

            PropertyInfo prop = controlType.GetProperty(objParams[0].ToString());
            prop.SetValue(control, objParams[1], null);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ThreadTool
            // 
            this.Name = "ThreadTool";
            this.Size = new System.Drawing.Size(232, 74);
            this.Load += new System.EventHandler(this.ThreadTool_Load);
            this.ResumeLayout(false);

        }

        private void ThreadTool_Load(object sender, EventArgs e)
        {

        }
    }
    
}
