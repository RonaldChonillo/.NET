using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Collections;
using System.DirectoryServices;
using ServerEnumerator;

namespace UDPDataServer
{
    public partial class frmUDPReceive : Form
    {
        UDPManager udpMain = new UDPManager();
        System.Threading.ThreadTool threadtool;
        //UdpClient receivingUdpClient;
        //IPEndPoint RemoteIpEndPoint = new IPEndPoint( IPAddress.Any , 0 );
        //Thread ThreadReceive;
        //int SocketNO;

        public frmUDPReceive()
        {
            InitializeComponent();
        }

        //public void ReceiveMessages()
        //{
        //try
        //{
        //    Byte[] receiveBytes = receivingUdpClient.Receive( ref RemoteIpEndPoint );
            
        //    txtIP.Text = RemoteIpEndPoint.Address.ToString();

        //    BitArray BitDet;
        //    BitDet = new BitArray( receiveBytes );

        //    String strReturnData = System.Text.Encoding.Unicode.GetString(receiveBytes);
        //    Console.WriteLine("A message is received and being processed");
        //    TextBox1.Text = TextBox1.Text + "\nA message is received and being processed";
        //    Console.WriteLine("The length of the message is ");
        //    TextBox1.Text = TextBox1.Text + "\nThe length of the message is ";
        //    Console.WriteLine(receiveBytes.Length);
        //    TextBox1.Text = TextBox1.Text + receiveBytes.Length;
        //    Console.WriteLine(strReturnData);
        //    TextBox1.Text = TextBox1.Text + "\nThe message received is ";
        //    TextBox1.Text = TextBox1.Text + Encoding.ASCII.GetChars(receiveBytes) + "";
        //    TextBox1.Text = TextBox1.Text + "\n";
        //    String tempStr=null;
        //    String tempStr2;
        //    if ( chkBit.Checked )
        //    {
        //        int i;
        //        i = 0;
        //        int j;
        //        j = 0;
        //        int line;
        //        line = 0;
        //        TextBox1.Text = TextBox1.Text + line.ToString() + ") ";
        //        //For j = 0 To BitDet.Length - 1
        //        for ( j = 0; j < BitDet.Length ; j++ )
        //        {
        //            if ( BitDet[j] == true )
        //            {
        //                Console.Write("1 ");
        //                tempStr2 = tempStr;
        //                tempStr = " 1" + tempStr2;
        //            }
        //            else
        //            {
        //                Console.Write("0 ");
        //                tempStr2 = tempStr;
        //                tempStr = " 0" + tempStr2;
        //            }
                    
        //            i += 1;
        //            if( i == 8 && j <= (BitDet.Length - 1) )
        //            {
        //                line += 1;
        //                i = 0;
        //                TextBox1.Text = TextBox1.Text + tempStr;
        //                tempStr = "";
        //                tempStr2 = "";
        //                TextBox1.Text = TextBox1.Text + "\n";
        //                if ( j != (BitDet.Length - 1) )
        //                {
        //                    TextBox1.Text = TextBox1.Text + line.ToString() + ") ";
        //                    Console.WriteLine();
        //                }
        //            }
        //        }
        //    }
        //    TextBox1.Text = TextBox1.Text + "\n";
        //    NewInitialize();
        //}
        //catch ( Exception e )
        //{
        //    Console.WriteLine( e.Message );
        //}
        
        //}

        //public void NewInitialize()
        //{
        //    Console.WriteLine("Thread *Thread Receive* reinitialized");
        //    ThreadReceive = new System.Threading.Thread( ReceiveMessages );
        //    ThreadReceive.Start();
        //}

        public string GetIPAddress(String CompName )
        {
            IPAddress oAddr;
            String sAddr;            
            try
            {                
                oAddr = new IPAddress( Dns.GetHostEntry(CompName).AddressList[0].GetAddressBytes() );
                sAddr = oAddr.ToString();
                return sAddr;
                
            }
            catch ( Exception )
            {
                //MessageBox.Show( Excep.Message );
            }
            return "000.000.000.000";
        }

        private void frmUDPReceive_Load( object sender , EventArgs e )
        {
            threadtool = new System.Threading.ThreadTool(this);

            //udpMain.txtMessages = TextBox1;
            //udpMain.txtIP = txtIP;
            //udpMain.m_Socket = txtSocket;
            //udpMain.dgvMessages = dgvMessages;

            //ServerEnum servers = new ServerEnum( ResourceScope.RESOURCE_GLOBALNET , 
            //                                    ResourceType.RESOURCETYPE_DISK , 
            //                                    ResourceUsage.RESOURCEUSAGE_ALL , 
            //                                    ResourceDisplayType.RESOURCEDISPLAYTYPE_SERVER );

            //TreeNode ndMain = trvPC.Nodes.Add( "Conectados" );

            //foreach ( string s1 in servers )
            //{
            //    string strResult;
            //    string strIP;
            //    strResult = s1;
            //    strResult = strResult.Replace( @"\" , "" );
            //    strIP = GetIPAddress( strResult );

            //    if ( strIP != "000.000.000.000" )
            //    {
            //        TreeNode ndChild = new TreeNode( strResult );
            //        ndChild.Tag = strIP;
            //        ndChild.ToolTipText = "IP:" + strIP;
            //        ndMain.Nodes.Add( ndChild );
            //    }
            //}

            //ndMain.Expand();

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
            dgvMessages.Rows.Add(
                            new object[]
                            {
                                e.MessageType.ToString() , 
                                e.Title , 
                                e.Message , 
                                e.FromIP, 
                                e.ToIP, 
                                e.FromName, 
                                e.DateSended.ToString() , 
                                e.Port.ToString()
                            }
                            );
        }

        private void Clear_Click( object sender , EventArgs e )
        {
            TextBox1.Text = "INFORMATION";
            dgvMessages.Rows.Clear();
        }

        private void Button1_Click( object sender , EventArgs e )
        {
            udpMain.Port = int.Parse(txtPort.Text);
            udpMain.BeginListening();
            btnStopListening.Enabled = true;
            btnBeginListening.Enabled = false;
            txtSocket.ReadOnly = true;            
        }

        private void frmUDPReceive_FormClosing( object sender , FormClosingEventArgs e )
        {
            //try
            //{
            //    receivingUdpClient.Close();
            //}
            //catch ( Exception ex )
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //udpMain.StopListening( true );
            //udpMain.Dispose();
        }

        private void Button2_Click( object sender , EventArgs e )
        {
            udpMain.StopListening( false );            
            btnStopListening.Enabled = false;
            btnBeginListening.Enabled = true;
            txtSocket.ReadOnly = false;
        }

        private void cmdSend_Click( object sender , EventArgs e )
        {
            UDPMessage udpMes = new UDPMessage();            
            udpMes.Port = int.Parse(txtPort.Text);
            udpMes.Message = txtMessage.Text;
            udpMes.ToIP = "192.168.14.61";
            udpMain.Send( udpMes );
            udpMes = null;

            //int intIndex;

            //for ( intIndex = 0 ; intIndex < trvPC.Nodes [ 0 ].Nodes.Count ; intIndex++ )
            //{
            //    if ( trvPC.Nodes [ 0 ].Nodes [ intIndex ].Checked )
            //    {
            //        udpMes.ToIP = trvPC.Nodes [ 0 ].Nodes [ intIndex ].Tag.ToString();
            //        udpMain.Send( udpMes );
            //    }
            //}

        }

        private void TreeView1_NodeMouseClick( object sender , TreeNodeMouseClickEventArgs e )
        {
            //lblIP.Text = 
            //TreeNode trnItem = ( TreeNode ) ;
            
        }

        private void TreeView1_AfterSelect( object sender , TreeViewEventArgs e )
        {

        }
    }
}