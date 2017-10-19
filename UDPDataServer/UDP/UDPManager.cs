using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using Microsoft.VisualBasic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Collections;
using System.Windows.Forms;


public class UDPManager:IDisposable
{
    //Receiver
    UdpClient receivingUdpClient;
    IPEndPoint RemoteIpEndPoint = new IPEndPoint( IPAddress.Any , 0 );
    Thread ThreadReceive;

    //Sender
    IPAddress  GLOIP;
    int GLOINTPORT;
    Byte [] bytCommand = new Byte [] { };

    //Delegado
    public delegate void ReceiveEventHandler(object sender, UDPMessage e);
    // Event.
    public event ReceiveEventHandler ReceiveMessage;

    //Delegado
    public delegate void ReceiveExceptionEventHandler(object sender, Exception e);
    // Event.
    public event ReceiveExceptionEventHandler ReceiveException;

    //Delegado
    public delegate void ReceiveInfoEventHandler(object sender, UDPInfo e);
    // Event.
    public event ReceiveInfoEventHandler ReceiveInfo;
    
    //Objetos de Informacion    
    private int m_intPort = 0;
    private string[] m_separator = { "[|-->]" };
    
    public UDPManager()
    {
        
    }

    public int Port
    {
        get
        {
            return m_intPort;
        }
        set
        {
            m_intPort = value;
        }
    }

    public void StopListening( bool blClosing )
    {
        try
        {
            ThreadReceive.Abort();
            receivingUdpClient.Close();
        }
        catch (Exception e)
        {
            //Raise
            if(ReceiveException!=null)
                ReceiveException( this , e );
        }
    }

    private void NewInitialize()
    {        
        ThreadReceive = new Thread(new ThreadStart( ReceiveMessages) );
        ThreadReceive.Name = "ReceiveMessages from UDPManager";
        ThreadReceive.Start();
    }

    public bool BeginListening()
    {
        bool blResult = true;

        try
        {            
            receivingUdpClient = new UdpClient(m_intPort);
            ThreadReceive = new Thread( new ThreadStart( ReceiveMessages) );
            ThreadReceive.Name = "ReceiveMessages from UDPManager";
            ThreadReceive.Start();
        }
        catch ( Exception e )
        {
            //Raise
            if(ReceiveException!=null)
                ReceiveException(this, e);
            blResult = false;
        }

        return blResult;
    }    

    private void ReceiveMessages()
    {
        try
        {
            string strIP;
            string strResult;
            if (receivingUdpClient == null) return;

            Byte [] receiveBytes = receivingUdpClient.Receive( ref RemoteIpEndPoint );
            BitArray BitDet;
            BitDet = new BitArray( receiveBytes );
            strResult = Encoding.ASCII.GetString( receiveBytes );
            string[] strResults= strResult.Split(m_separator, StringSplitOptions.None);
            strIP = RemoteIpEndPoint.Address.ToString();

            UDPMessage udpMes = new UDPMessage();
            udpMes.MessageType = (UDPMessage.UDPMessageType) 
                        Enum.Parse(typeof(UDPMessage.UDPMessageType), strResults[0]);
            udpMes.Title = strResults[1];
            udpMes.Message = strResults[2];
            udpMes.FromIP = strIP; //strResults[4];
            udpMes.ToIP = strResults[4];
            udpMes.FromName = strResults[5];
            udpMes.DateSended = strResults[6];
            udpMes.Port = int.Parse(strResults[7]);
            udpMes.ID = int.Parse(strResults[8]);
            udpMes.IDSource = int.Parse(strResults[9]);
            udpMes.RequireReceived = bool.Parse(strResults[10]);


            if (udpMes.MessageType == UDPMessage.UDPMessageType.udpm_Common &&
                udpMes.RequireReceived )
            {
                UDPMessage udpConf = new UDPMessage();
                udpConf.MessageType = UDPMessage.UDPMessageType.udpm_ReceivedConfirm;
                udpConf.Message = "Mensaje recibido en " + udpMes.ToIP;
                udpConf.ToIP = strIP;
                udpConf.Port = udpMes.Port;
                Send(udpConf);
                udpConf = null;
            }

            if (udpMes.MessageType == UDPMessage.UDPMessageType.udpm_CrossCheck)
            {
                UDPMessage udpConf = new UDPMessage();
                udpConf.MessageType = UDPMessage.UDPMessageType.udpm_ReceivedConfirm;
                udpConf.Message = ">>>" + udpMes.ToIP;
                udpConf.ToIP = strIP;
                udpConf.Port = udpMes.Port;
                Send(udpConf);
                udpConf = null;
            }

            if (ReceiveMessage != null)
                ReceiveMessage(this, udpMes);

            NewInitialize();

            //udpMes = null;
            //receiveBytes = null;
            //BitDet = null;
        }
        catch ( Exception e )
        {
            //Raise
            if(ReceiveException!=null)
                ReceiveException(this, e);
        }
    }

    public bool Send( UDPMessage udpMessage )
    {
        bool blReturn = true;
        int pRet;
        UdpClient udpClient = new UdpClient();
        string strMessageObjArray = "";

        /**********************/
        udpMessage.FromName = Dns.GetHostName();        
        IPAddress[] ipaRank;
        ipaRank = Dns.GetHostAddresses(Dns.GetHostName());

        foreach (IPAddress ip in ipaRank)
        {
            udpMessage.FromIP += ip.ToString() + ";";
        }
        /**********************/


        try
        {
            GLOIP = IPAddress.Parse( udpMessage.ToIP );
            GLOINTPORT = udpMessage.Port;
            udpClient.Connect( GLOIP , GLOINTPORT );
            //Console.WriteLine("Connected to client");
            /**/
            strMessageObjArray =                        
                        udpMessage.MessageType.ToString() + m_separator[0] +
                        udpMessage.Title + m_separator[0] +
                        udpMessage.Message + m_separator[0] +
                        udpMessage.FromIP + m_separator[0] +
                        udpMessage.ToIP + m_separator[0] +
                        udpMessage.FromName + m_separator[0] +
                        udpMessage.DateSended.ToString() + m_separator[0] +
                        udpMessage.Port.ToString() + m_separator[0] + 
                        udpMessage.ID.ToString() + m_separator[0] +
                        udpMessage.IDSource.ToString() + m_separator[0] +
                        udpMessage.RequireReceived.ToString() + m_separator[0];
            /**/
            //Console.WriteLine("Message created");
            //bytCommand = Encoding.ASCII.GetBytes( udpMessage.Message );
            bytCommand = Encoding.ASCII.GetBytes(strMessageObjArray);
            pRet = udpClient.Send( bytCommand , bytCommand.Length );
            //Console.WriteLine("Sended");

            if (ReceiveInfo != null)
                ReceiveInfo(this, new UDPInfo(UDPInfo.UDPInfoType.udpm_SendedConfirm, "Enviado", udpMessage.ToIP));
        }
        catch ( Exception e )
        {
            //Raise
            if(ReceiveException!=null)
                ReceiveException(this, e);
            blReturn = false;
        }
        finally
        {
            udpClient.Close();
            udpClient = null;
        }
        return blReturn;
    }

    /// <summary>
    /// Mata la clase
    /// </summary>
    public void Dispose()
    {
        StopListening( true );
    }    
}