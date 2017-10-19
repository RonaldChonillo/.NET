using System;
using System.Collections.Generic;
using System.Text;

public class UDPMessage
{
    public enum UDPMessageType
    {
        udpm_Common = 0,
        udpm_ReceivedConfirm = 1,
        udpm_CrossCheck = 2,
        udpm_Command = 3,
    }

    UDPMessageType m_UDPMessageType = UDPMessageType.udpm_Common;
    String m_strMessageTitle = "";
    String m_strMessageContent = "";
    String m_strFromIP = "";
    String m_strToIP = "";
    String m_strFromName = "";
    String m_dttSended = DateTime.Now.ToString();
    int m_intPort = 0;
    int m_ID = 0;       //Identificador del mensaje, 
                        //no se controla internamente
    int m_IDSource      = 0; //ID de origen de mensaje
    bool m_request_received  = false;


    public bool RequireReceived
    {
        get
        {
            return m_request_received;
        }
        set
        {
            m_request_received = value;
        }
    }

    public int ID
    {
        get
        {
            return m_ID;
        }
        set
        {
            m_ID = value;
        }
    }

    public int IDSource
    {
        get
        {
            return m_IDSource;
        }
        set
        {
            m_IDSource = value;
        }
    }

    public String DateSended
    {
        get
        {
            return m_dttSended;
        }
        set
        {
            m_dttSended = value;
        }
    }

    public UDPMessageType MessageType
    {
        get
        {
            return m_UDPMessageType;
        }
        set
        {
            m_UDPMessageType = value;
        }
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

    public String Title
    {
        get
        {
            return m_strMessageTitle;
        }
        set
        {
            m_strMessageTitle = value;
        }
    }

    public String Message
    {
        get
        {
            return m_strMessageContent;
        }
        set
        {
            m_strMessageContent = value;
        }
    }

    public String FromIP
    {
        get
        {
            return m_strFromIP;
        }
        set
        {
            m_strFromIP = value;
        }
    }

    public String ToIP
    {
        get
        {
            return m_strToIP;
        }
        set
        {
            m_strToIP = value;
        }
    }

    public String FromName
    {
        get
        {
            return m_strFromName;
        }
        set
        {
            m_strFromName = value;
        }
    }
}