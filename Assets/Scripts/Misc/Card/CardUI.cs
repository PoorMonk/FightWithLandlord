using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardUI{

    Card m_card;
    Image m_cardImg;
    bool m_isSelected;
    Button m_btn;

    public Card Card
    {
        get
        {
            return m_card;
        }

        set
        {
            m_card = value;
        }
    }

    public void SetImage()
    {
        if (m_card.BelongTo == CharacterType.Player || m_card.BelongTo == CharacterType.Desk)
        {
            m_cardImg.sprite = Resources.Load<Sprite>("Pokers/" + m_card.CardName);
        }
        else
        {
            m_cardImg.sprite = Resources.Load<Sprite>("Pokers/FixedBack");
        }
    }

    public void SetDeskImage()
    {
        m_cardImg.sprite = Resources.Load<Sprite>("Pokers/CardBack");
    }
}
