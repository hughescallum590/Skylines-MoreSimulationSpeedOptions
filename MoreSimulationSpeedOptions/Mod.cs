﻿using ColossalFramework.UI;
using ICities;
using UnityEngine;

namespace MoreSimulationSpeedOptions
{

    public class Mod : IUserMod
    {

        public string Name
        {
            get { return "MoreSimulationSpeedOptions"; }
        }

        public string Description
        {
            get { return "What it says on the box"; }
        }

    }
    public class ModLoad : LoadingExtensionBase
    {


        public override void OnLevelLoaded(LoadMode mode)
        {
            var uiView = GameObject.FindObjectOfType<UIView>();
            uiView.gameObject.AddComponent<Hook>();
        }

    }

}
