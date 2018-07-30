using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour{

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

    public bool IsSelected
    {
        get
        {
            return m_isSelected;
        }

        set
        {
            if (m_card.BelongTo != CharacterType.Player || m_isSelected == value)
            {
                return;
            }
            if (value)
            {
                transform.localPosition += Vector3.up * 10;
            }
            else
            {
                transform.localPosition -= Vector3.up * 10;
            }
            m_isSelected = value;
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

    public void SetPosition(Transform parent, int index)
    {
        transform.SetParent(parent, false);
        transform.SetSiblingIndex(index);
        if (m_card.BelongTo == CharacterType.Desk || m_card.BelongTo == CharacterType.Player)
        {
            transform.localPosition = Vector3.right * index * 20;
            if (m_isSelected)
            {
                transform.localPosition += Vector3.up * 10;
            }
        }
        if (m_card.BelongTo == CharacterType.ComputerLeft || m_card.BelongTo == CharacterType.ComputerRight)
        {
            transform.position = -Vector3.up * 8 * index + Vector3.left * 8 * index;
        }
    }

    /// <summary>
    /// 生成牌
    /// </summary>
    public void OnSpawn()
    {
        m_cardImg = GetComponent<Image>();
        m_btn = GetComponent<Button>();
        m_btn.onClick.AddListener(OnSelectCardClicked);
    }

    public void OnSelectCardClicked()
    {
        if (m_card.BelongTo == CharacterType.Player)
        {
            IsSelected = !IsSelected;
        }
    }

    /// <summary>
    /// 回收牌
    /// </summary>
    public void OnDespawn()
    {
        m_btn.onClick.RemoveListener(OnSelectCardClicked);
        m_cardImg.sprite = null;
        m_isSelected = false;
        m_card = null;
    }
}
