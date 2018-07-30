using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card{

    string m_cardName;
    Weight m_cardWeigth;
    Colors m_cardColor;
    CharacterType m_belongTo;

    #region 属性
    public string CardName
    {
        get
        {
            return m_cardName;
        }        
    }

    public Weight CardWeigth
    {
        get
        {
            return m_cardWeigth;
        }
    }

    public Colors CardColor
    {
        get
        {
            return m_cardColor;
        }
    }

    public CharacterType BelongTo
    {
        get
        {
            return m_belongTo;
        }

        set
        {
            m_belongTo = value;
        }
    }
    #endregion

    public Card(string name, Weight weight, Colors col, CharacterType belongTo)
    {
        m_cardName = name;
        m_cardColor = col;
        m_cardWeigth = weight;
        BelongTo = belongTo;
    }
}
