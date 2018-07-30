using strange.extensions.mediation.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMediator : EventMediator {
    [Inject]public StartView StartView { set; get; }
    public override void OnRegister()
    {
        StartView.m_doubleBtn.onClick.AddListener(OnDoubleBtnClicked);
        StartView.m_noDoubleBtn.onClick.AddListener(OnNoDoubleBtnClicked);
    }

    public override void OnRemove()
    {
        StartView.m_doubleBtn.onClick.RemoveListener(OnDoubleBtnClicked);
        StartView.m_noDoubleBtn.onClick.RemoveListener(OnNoDoubleBtnClicked);
    }

    public void OnDoubleBtnClicked()
    {
        dispatcher.Dispatch(CommandEvent.ChangeMultipleCommand, 1);
        Destroy(StartView.gameObject);
    }

    public void OnNoDoubleBtnClicked()
    {
        dispatcher.Dispatch(CommandEvent.ChangeMultipleCommand, 2);
        Destroy(StartView.gameObject);
    }
}
