using strange.extensions.command.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMultipleCommand : EventCommand {
    [Inject]public IntegrationModel IntegrationModel { set; get; }
    public override void Execute()
    {
        int temp = (int)evt.data;
        IntegrationModel.m_multiple *= temp;
    }
}
