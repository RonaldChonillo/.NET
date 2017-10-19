using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UDPDataServer
{
    public partial class frmUDPStations : Form
    {
        UDPManager udpMain = new UDPManager();

        System.Threading.ThreadTool threadtool;

        public frmUDPStations()
        {
            InitializeComponent();
        }

        private void frmUDPStations_Load(object sender, EventArgs e)
        {
            threadtool = new System.Threading.ThreadTool(this);

            dgvMessages.Columns.Add("1", "1");
            dgvMessages.Columns.Add("2", "2");
            dgvMessages.Columns.Add("3", "3");
            dgvMessages.Columns.Add("4", "4");
            dgvMessages.Columns.Add("5", "5");
            dgvMessages.Columns.Add("6", "6");
            dgvMessages.Columns.Add("7", "7");
            dgvMessages.Columns.Add("8", "8");


            udpMain.ReceiveMessage += new UDPManager.ReceiveEventHandler(udpMain_ReceiveMessage);
            udpMain.ReceiveException += new UDPManager.ReceiveExceptionEventHandler(udpMain_ReceiveException);
            udpMain.ReceiveInfo += new UDPManager.ReceiveInfoEventHandler(udpMain_ReceiveInfo);

        }

        void udpMain_ReceiveInfo(object sender, UDPInfo e)
        {
            threadtool.InvokeChangeObjectProperty(TextBox1, new object[] { "Text", Environment.NewLine + e.MessageInfo });            
        }

        void udpMain_ReceiveException(object sender, Exception e)
        {
            threadtool.InvokeChangeObjectProperty(TextBox1, new object[] { "Text", Environment.NewLine + e.Message });
        }

        void udpMain_ReceiveMessage(object sender, UDPMessage e)
        {
            dgvMessages.Rows.Add(new object[] { e.MessageType.ToString() , 
                            e.Title ,
                            e.Message ,
                            e.FromIP, 
                            e.ToIP, 
                            e.FromName,
                            e.DateSended.ToString(),
                            e.Port.ToString()});
        }

        private void btnBeginListening_Click(object sender, EventArgs e)
        {
            udpMain.Port = int.Parse(txtSocket.Text);
            udpMain.BeginListening();
            btnStopListening.Enabled = true;
            btnBeginListening.Enabled = false;
            txtSocket.ReadOnly = true;
        }

        private void btnStopListening_Click(object sender, EventArgs e)
        {
            udpMain.StopListening(false);
            btnStopListening.Enabled = false;
            btnBeginListening.Enabled = true;
            txtSocket.ReadOnly = false; 
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            dgvMessages.Rows.Clear();
        }
    }
}