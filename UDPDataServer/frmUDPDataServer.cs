using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServerEnumerator;
using System.Threading;
using System.Net;

namespace UDPDataServer
{
    public partial class frmUDPDataServer : Form
    {
        UDPManager udpMain;
        System.Threading.ThreadTool threadtool;

        int intTimeIni = 4;

        //Thread threadUpdateServers;

        public frmUDPDataServer()
        {
            InitializeComponent();
        }

        public string GetIPAddress(String CompName)
        {           
            string sAddr="";

            try
            {
                foreach (IPAddress ipIndex in Dns.GetHostEntry(CompName).AddressList)
                {
                    sAddr += ipIndex.ToString()+";";
                }
            }
            catch (Exception)
            {
                //MessageBox.Show( Excep.Message );
                sAddr = "000.000.000.000";
            }

            return sAddr;
        }

        //private void LoadServers()
        //{
        //    Console.Write("Búsqueda de servidores...");

        //    ServerEnum servers = new ServerEnum(ResourceScope.RESOURCE_GLOBALNET,
        //                                        ResourceType.RESOURCETYPE_DISK,
        //                                        ResourceUsage.RESOURCEUSAGE_ALL,
        //                                        ResourceDisplayType.RESOURCEDISPLAYTYPE_SERVER);

        //    threadtool.InvokeCallMethod(dgvServers.Rows, "Clear", null);

        //    DataTable dtt = new DataTable();
        //    dtt.Columns.Add("NAME");
        //    dtt.Columns.Add("INFO");
        //    foreach (string s1 in servers)
        //    {
        //        string strResult;
        //        strResult = s1;
        //        strResult = strResult.Replace(@"\", "");
        //        DataRow drItem = dtt.NewRow();
        //        drItem["NAME"] = strResult;
        //        dtt.Rows.Add(drItem);
        //        //threadtool.InvokeCallMethod(dgvServers.Rows, "Add", new object[] { "", strResult, "" });
        //        //dgvServers.Rows.Add(new object[] { "", strResult, "" });
        //    }

        //    threadtool.InvokeCallMethod(dgvServers.Columns, "Insert", new object[] { 0, new DataGridViewImageColumn() });
        //    //dgvServers.Columns.Insert(0, new DataGridViewImageColumn());

        //    threadtool.InvokeChangeObjectProperty(dgvServers, new object[] { "DataSource",dtt });
        //    threadtool.InvokeChangeObjectProperty(dgvServers.Columns[0], new object[] { "Width", 25 });
        //    threadtool.InvokeChangeObjectProperty(lblServerIndicador, new object[] { "Text", "Terminado..." });
        //    threadtool.InvokeChangeObjectProperty(lblServerIndicador, new object[] { "Image", global::UDPDataServer.Properties.Resources.icon_success });            
        //    threadtool.InvokeChangeObjectProperty(btnRefreshServers, new object[] { "Enabled", true });

        //    foreach (DataGridViewRow drItem in dgvServers.Rows)
        //    {
        //        DataGridViewImageCell imgCell = (DataGridViewImageCell)drItem.Cells[0];
        //        threadtool.InvokeChangeObjectProperty(imgCell, new object[] { "Value", global::UDPDataServer.Properties.Resources.gif_comunication_off });
        //        //imgCell.Value = global::UDPDataServer.Properties.Resources.gif_comunication_off;
        //    }
        //}
        
        private void frmUDPDataServer_Load(object sender, EventArgs e)
        {
            threadtool = new System.Threading.ThreadTool(this);

            udpMain = new UDPManager();
            udpMain.ReceiveException += new UDPManager.ReceiveExceptionEventHandler(udpMain_ReceiveException);
            udpMain.ReceiveInfo += new UDPManager.ReceiveInfoEventHandler(udpMain_ReceiveInfo);
            udpMain.ReceiveMessage += new UDPManager.ReceiveEventHandler(udpMain_ReceiveMessage);
            udpMain.Port = int.Parse(txtSocket.Text);

            dgvMessages.Columns.Add("Tipo","Tipo");
            dgvMessages.Columns.Add("Titulo","Titulo");
            dgvMessages.Columns.Add("Mensaje","Mensaje");
            dgvMessages.Columns.Add("IP","IP");
            dgvMessages.Columns.Add("A","A");
            dgvMessages.Columns.Add("Estacion","Estacion");
            dgvMessages.Columns.Add("Fecha", "Fecha");
            dgvMessages.Columns.Add("Socket", "Socket");
            dgvMessages.RowHeadersVisible = false;
            dgvMessages.ScrollBars = ScrollBars.Vertical; 

            
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "IMG";
            imgCol.HeaderText = "";
            imgCol.Width = 20;
            imgCol.Resizable =  DataGridViewTriState.False;
            dgvStations.Columns.Add(imgCol);
            dgvStations.Columns.Add("NAME", "Estación");
            dgvStations.Columns.Add("IP", "Ip");
            dgvStations.Columns.Add("INFO", "Información");
            dgvStations.Columns.Add("Login", "Login");
            dgvStations.Columns.Add("VERSION", "Versión");
            dgvStations.RowHeadersVisible = false;
            dgvStations.ReadOnly = true;
            dgvStations.AllowUserToResizeRows = false;

            dgvStations.Columns["INFO"].Visible = false;
            
           //-----------------------------------------------------//

            dgvDataActivity.Columns.Add("FileName", "Archivo");
            dgvDataActivity.Columns.Add("Station", "Estacion");
            dgvDataActivity.Columns.Add("Status", "Status");
            dgvDataActivity.Columns.Add("Date", "Fecha");
            dgvDataActivity.Columns.Add("Requests", "Accesos");
            dgvDataActivity.ReadOnly = true;
            dgvDataActivity.AllowUserToAddRows = false;

            tmrMain.Enabled = true;

            Console.WriteLine("Cargado correctamente");
        }

        int ExistStation(string IP)
        {
            int intResult = -1;
            foreach( DataGridViewRow drItem in dgvStations.Rows)
            {
                if(drItem.Cells["IP"].Value.ToString().Equals(IP))
                {
                    intResult = drItem.Index;
                }
            }
            return intResult;
        }

        void EvalStation(UDPMessage e)
        {
            string strLogin = "";
            string strVersion = "";
            //Console.WriteLine(e.Message);
            string[] strMessage = e.Message.Split(';');
            strVersion = strMessage[2];

            if (strMessage[1].ToLower() == "false")
                strLogin = "-";
            else
                strLogin = strMessage[0].ToLower().Replace("login:", "");

            int IndexResult = ExistStation(e.FromIP);

            if (IndexResult == -1)
            {
                dgvStations.Rows.Add(global::UDPDataServer.Properties.Resources.gif_comunication_on, e.FromName, e.FromIP, e.Port, strLogin, strVersion);
            }
            else
            {
                dgvStations["Login", IndexResult].Value = strLogin;
            }
        }

        int ExistItem(string FieldName, string Value, DataGridView dgvObj)
        {
            int intResult = -1;
            foreach (DataGridViewRow drItem in dgvObj.Rows)
            {
                if (drItem.Cells[FieldName].Value.ToString().Equals(Value))
                {
                    intResult = drItem.Index;
                }
            }
            return intResult;
        }

        void EvalCommand(UDPMessage e)
        {
            string strStatus = "-";
            string strFree = "Liberado";
            string strLocked = "Reservado";
            string strNotFound = "notfound";

            //PARA PONER ESTADO DE ARCHIVO
            if(e.Title.Trim()=="setrecerved")
                strStatus = strLocked;
            if (e.Title.Trim() == "setaccesible")
            {
                strStatus = strFree;
            }

            if (strStatus == strFree || strStatus == strLocked)
            {
                int IndexResult = ExistItem("FileName", e.Message, dgvDataActivity);

                if (IndexResult == -1)
                {
                    dgvDataActivity.Rows.Add(e.Message, e.FromName + " " + e.FromIP, strStatus, e.DateSended.ToString(), "");
                }
                else
                {
                    dgvDataActivity["Status", IndexResult].Value = strStatus;

                    //Envio de notificación de archivo
                    if (dgvDataActivity["Requests", IndexResult].Value.ToString().Contains(';'))
                    {
                        string[] IpList = dgvDataActivity["Requests", IndexResult].Value.ToString().Split(';');
                        foreach (string IpItem in IpList)
                        {
                            UDPMessage udpMens = new UDPMessage();
                            udpMens.MessageType = UDPMessage.UDPMessageType.udpm_Common;
                            udpMens.Title = "Archivo Liberado";
                            udpMens.Port = e.Port;
                            udpMens.Message = e.Message;
                            udpMens.ToIP = IpItem;
                            udpMain.Send(udpMens);
                            udpMens = null;
                        }                        
                    }
                }
            }

            //PETICION DE ESTADO DE ARCHIVO
            if (e.Title.Trim() == "retreivestatusfile")
            {
                //dgvMessages.Rows.Add(new object[] { "Peticion de estado de archivos" , 
                //            "" ,
                //            "" ,
                //            "", 
                //            "", 
                //            "",
                //            e.DateSended.ToString(),
                //            e.Port.ToString()});

                int IndexResult = ExistItem("FileName", e.Message, dgvDataActivity);

                UDPMessage udpMens = new UDPMessage();
                udpMens.MessageType = UDPMessage.UDPMessageType.udpm_Command;
                udpMens.Title = "retreivestatusfileresult";
                udpMens.Port = e.Port;

                if (IndexResult > -1)
                {
                    udpMens.Message = e.Message + ";" + dgvDataActivity["Status", IndexResult].Value.ToString();
                    dgvDataActivity["Requests", IndexResult].Value += e.FromIP + ";";
                }
                else
                    udpMens.Message = e.Message + ";" + strNotFound;

                udpMens.ToIP = e.FromIP;
                udpMain.Send(udpMens);
                udpMens = null;

                dgvMessages.Rows.Add(new object[] { "Peticion de estado de archivos enviada a " + e.FromIP + " " + e.FromName , 
                            "" ,
                            "" ,
                            "", 
                            "", 
                            "",
                            e.DateSended.ToString(),
                            e.Port.ToString()});
            }
        }

        //void udpMain_ReceiveMessage(object sender, UDPMessage e)
        //{
        //    //txtComm.Text += Environment.NewLine + e.Message;
        //    //if (e.MessageType == UDPMessage.UDPMessageType.udpm_ReceivedConfirm)
        //    //{
        //    //    picComm.Image = global::UDPDataServer.Properties.Resources.gif_comunication_on_b;
        //    //    tssComm.Image = global::UDPDataServer.Properties.Resources.gif_comunication_on;            
        //    //}
        //    //else
        //    //{
        //    //    picComm.Image = global::UDPDataServer.Properties.Resources.gif_comunication_off_b;
        //    //    tssComm.Image = global::UDPDataServer.Properties.Resources.gif_comunication_off;
        //    //}
        //}

        void udpMain_ReceiveMessage(object sender, UDPMessage e)
        {
            //Console.WriteLine(e.MessageType.ToString());

            if (e.MessageType == UDPMessage.UDPMessageType.udpm_CrossCheck)
            {
                EvalStation(e);
                return;
            }

            if (e.MessageType == UDPMessage.UDPMessageType.udpm_Command)
            {
                EvalCommand(e);
                return;
            }

            dgvMessages.Rows.Add(new object[] { e.MessageType.ToString() , 
                            e.Title ,
                            e.Message ,
                            e.FromIP, 
                            e.ToIP, 
                            e.FromName,
                            e.DateSended.ToString(),
                            e.Port.ToString()});

            //if (e.MessageType == UDPMessage.UDPMessageType.udpm_ReceivedConfirm)
            //{
            //    picComm.Image = global::UDPDataServer.Properties.Resources.gif_comunication_on;                
            //}
            //else
            //{
            //    picComm.Image = global::UDPDataServer.Properties.Resources.gif_comunication_off;                
            //}
        }

        void udpMain_ReceiveInfo(object sender, UDPInfo e)
        {
            if (e.InfoType == UDPInfo.UDPInfoType.udpm_SendedConfirm) return;

            if (threadtool != null)
                threadtool.InvokeChangeObjectProperty(txtComm, new object[] { "Text", txtComm.Text + e.Title + ":" + e.MessageInfo + Environment.NewLine });
        }

        void udpMain_ReceiveException(object sender, Exception e)
        {
            if(threadtool!=null)
                threadtool.InvokeChangeObjectProperty(txtComm, new object[] { "Text", txtComm.Text + "Error:" + e.Message + Environment.NewLine });
        }

        private void btnChangeMode_Click(object sender, EventArgs e)
        {
            //AppData.GetInputString("Ingrese el password", "",true);
           
            if (btnChangeMode.Text.Contains("Iniciar"))
            {
                lblServerSwitch.Text = "Server ON";
                lblServerSwitch.ForeColor = Color.YellowGreen;
                udpMain.Port = int.Parse(txtSocket.Text);
                udpMain.BeginListening();
                txtSocket.ReadOnly = true;
                picComm.Image = global::UDPDataServer.Properties.Resources.gif_comunication_on;
                btnChangeMode.Text = "Detener";
                Console.WriteLine("Servidor Iniciado");
            }
            else
            {
                if (MessageBox.Show("Desea continuar deteniendo el servicio?",
                    "Confirmación",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                    return;

                lblServerSwitch.Text = "Server OFF";
                lblServerSwitch.ForeColor = Color.Red;
                udpMain.StopListening(false);
                txtSocket.ReadOnly = false;
                picComm.Image = global::UDPDataServer.Properties.Resources.gif_comunication_off;
                btnChangeMode.Text = "Iniciar";
            }
        }

        private void mniStations_Click(object sender, EventArgs e)
        {
            frmUDPStations frmObj = new frmUDPStations();
            frmObj.Show();
        }

        private void mniReceiver_Click(object sender, EventArgs e)
        {
            frmUDPReceive frmObj = new frmUDPReceive();
            frmObj.Show();
        }

        private void frmUDPDataServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            udpMain.StopListening(true);
            udpMain.Dispose();
            udpMain = null;
            threadtool.Dispose();
            threadtool = null;

            //if (threadUpdateServers != null)
            //{
            //    threadUpdateServers.Interrupt();
            //    threadUpdateServers = null;
            //}
        }

        private void btnRefreshServers_Click(object sender, EventArgs e)
        {
            //lblServerIndicador.Text = "Buscando";
            //lblServerIndicador.Image = global::UDPDataServer.Properties.Resources.gif_indicator;            

            //threadUpdateServers = new Thread(new ThreadStart(LoadServers));
            //threadUpdateServers.Start();
        }        

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (dgvStations.SelectedCells.Count == 0) return ;

            string strStation;
            string strIP;

            strStation = dgvStations["NAME", dgvStations.SelectedCells[0].RowIndex].Value.ToString();
            strIP = dgvStations["IP", dgvStations.SelectedCells[0].RowIndex].Value.ToString();
            frmUDPSendMessage frmObj = new frmUDPSendMessage();
            frmObj.lblDestino.Text = "Destino (" + strStation + "):";
            frmObj.txtTarget.Text = strIP;
            frmObj.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvMessages.Rows.Clear();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            dgvStations.Rows.Clear();
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            if (intTimeIni == 0)
            {
                if (btnChangeMode.Text.Contains("Iniciar"))
                {
                    lblServerSwitch.Text = "Server ON";
                    lblServerSwitch.ForeColor = Color.YellowGreen;
                    udpMain.Port = int.Parse(txtSocket.Text);
                    udpMain.BeginListening();
                    txtSocket.ReadOnly = true;
                    picComm.Image = global::UDPDataServer.Properties.Resources.gif_comunication_on;
                    btnChangeMode.Text = "Detener";
                    tmrMain.Enabled = false;
                    tmrMain.Interval = 1000;
                    return;
                }
            }
            else
            {
                if (btnChangeMode.Text.Contains("Iniciar"))
                {
                    btnChangeMode.Text = "Iniciar(" + intTimeIni.ToString() + ")";
                }
                //else
                //{
                //    tmrMain.Enabled = false;
                //    tmrMain.Interval = 1000;
                //    return;
                //}
            }
            intTimeIni -= 1;
        }

        private void btnClearDone_Click(object sender, EventArgs e)
        {
            int IntIndex = 0;
            for (IntIndex = 0; IntIndex < dgvDataActivity.Rows.Count; IntIndex++ )
            {
                if (dgvDataActivity["Status",IntIndex].Value.ToString().Equals("Liberado"))
                {
                    dgvDataActivity.Rows[IntIndex].Visible = false;
                }
            }

            for (IntIndex = 0; IntIndex < dgvDataActivity.Rows.Count; IntIndex++)
            {
                if (dgvDataActivity.Rows[IntIndex].Visible == false)
                {
                    dgvDataActivity.Rows.RemoveAt(IntIndex);
                }
            }
        }

        private void dgvStations_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblTotalEstaciones.Text = dgvStations.Rows.Count.ToString() + " Estaciones";
        }

        private void dgvStations_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTotalEstaciones.Text = dgvStations.Rows.Count.ToString() + " Estaciones";
        }

        private void dgvDataActivity_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            lblTotalActividades.Text = dgvDataActivity.Rows.Count.ToString() + " Actividades";
        }

        private void dgvDataActivity_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            lblTotalActividades.Text = dgvDataActivity.Rows.Count.ToString() + " Actividades";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            dgvDataActivity.Rows.Clear();
        }
    }
}
