using System;
using System.Collections.Generic;
using System.Text;

public class UDPInfo
{
    public enum UDPInfoType
    {
        udpm_Error  = 1,
        udpm_Common = 2,
        udpm_SendedConfirm = 3,
    }

    private UDPInfoType m_InfoType = UDPInfoType.udpm_Common;
    private string m_strMessageTitle = "";
    private string m_strMessageInfo="";


    public UDPInfoType InfoType
    {
        get
        {
            return m_InfoType;
        }
        set
        {
            m_InfoType = value;
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

    public String MessageInfo
    {
        get
        {
            return m_strMessageInfo;
        }
        set
        {
            m_strMessageInfo = value;
        }
    }

    public UDPInfo(UDPInfoType Type, string Title, string MessageInfo)
    {
        m_InfoType = Type;
        m_strMessageTitle = Title;
        m_strMessageInfo = MessageInfo;
    }
}

