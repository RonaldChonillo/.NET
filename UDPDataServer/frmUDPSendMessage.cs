using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UDPDataServer
{
    public partial class frmUDPSendMessage : Form
    {
        UDPManager udpMain;
        public frmUDPSendMessage()
        {
            InitializeComponent();
        }

        private void cmdSend_Click(object sender, EventArgs e)
        {            
            
            UDPMessage udpMens = new UDPMessage();
            //udpMens.MessageType = UDPMessage.UDPMessageType.udpm_CrossCheck;
            udpMens.Title = txtTitle.Text;
            udpMens.Port = int.Parse(txtPort.Text);
            udpMens.Message = txtMessage.Text;
            udpMens.ToIP = txtTarget.Text;
            udpMain.Send(udpMens);
            udpMens = null;
            txtLog.Text += "Enviado:" + txtMessage.Text + Environment.NewLine;
            txtMessage.Text = "";
            txtMessage.Focus();
            //udpMain.Dispose();
            //udpMain = null;
        }

        void udpMain_ReceiveException(object sender, Exception e)
        {
            txtLog.Text += e.Message + Environment.NewLine;
        }

        private void frmUDPSendMessage_Load(object sender, EventArgs e)
        {
            udpMain = new UDPManager();
            udpMain.ReceiveException += new UDPManager.ReceiveExceptionEventHandler(udpMain_ReceiveException);
        }

        private void frmUDPSendMessage_FormClosing(object sender, FormClosingEventArgs e)
        {            
            udpMain.Dispose();
            udpMain = null;
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            cmdSend.Enabled = !string.IsNullOrEmpty(txtMessage.Text.Trim());
        }
    }
}
