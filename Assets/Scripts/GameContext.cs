using strange.extensions.context.impl;
using strange.extensions.context.api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContext : MVCSContext {

    public GameContext(MonoBehaviour view, bool autoMapping) : base(view, autoMapping)
	{
    }

    protected override void mapBindings()
    {
        // Model
        injectionBinder.Bind<IntegrationModel>().To<IntegrationModel>().ToSingleton();

        // Controller
        commandBinder.Bind(CommandEvent.ChangeMultipleCommand).To<ChangeMultipleCommand>();

        // View
        mediationBinder.Bind<StartView>().To<StartMediator>();

        commandBinder.Bind(ContextEvent.START).To<StartCommand>().Once();
    }
}
