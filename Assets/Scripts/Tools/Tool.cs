using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Tool{

    static Transform m_uiParent;

    public static Transform UiParent
    {
        get
        {
            if (m_uiParent == null)
            {
                m_uiParent = GameObject.Find("Canvas").transform;
            }
            return m_uiParent;
        }
    }

    public static GameObject CreateUIPanel(PanelType panelType)
    {
        GameObject go = Resources.Load<GameObject>(panelType.ToString());
        if (go == null)
        {
            Debug.Log("Panel is null: " + panelType.ToString());
            return null;
        }
        else
        {
            GameObject panel = GameObject.Instantiate(go);
            panel.name = panelType.ToString();
            // 不要使用世界坐标，必须将第二个参数设置为false
            panel.transform.SetParent(UiParent, false);
            return panel;
        }
    }
}
