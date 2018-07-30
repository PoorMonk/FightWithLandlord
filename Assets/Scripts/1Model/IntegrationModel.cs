using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntegrationModel{
    public int m_basePoint;
    public int m_multiple;
    private int m_playerIntegration;
    private int m_computerLeftIntegration;
    private int m_computerRightIntegration;

    #region 属性
    public int Result
    {
        get
        {
            return m_basePoint * m_multiple;
        }
    }

    public int PlayerIntegration
    {
        get
        {
            return m_playerIntegration;
        }

        set
        {
            m_playerIntegration = value;
        }
    }

    public int ComputerLeftIntegration
    {
        get
        {
            return m_computerLeftIntegration;
        }

        set
        {
            m_computerLeftIntegration = value;
        }
    }

    public int ComputerRightIntegration
    {
        get
        {
            return m_computerRightIntegration;
        }

        set
        {
            m_computerRightIntegration = value;
        }
    }
    #endregion

    public void InitIntegration()
    {
        m_basePoint = 100;
        m_multiple = 1;
        PlayerIntegration = 1500;
        ComputerLeftIntegration = 1500;
        ComputerRightIntegration = 1500;
        Debug.Log("InitIntegration...\n");
    }
}
