using strange.extensions.command.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartCommand : Command {

    [Inject]public IntegrationModel IntegrationModel { set; get; }

    public override void Execute()
    {
        Tool.CreateUIPanel(PanelType.StartPanel);

        // 初始化Model
        IntegrationModel.InitIntegration();
    }
}
