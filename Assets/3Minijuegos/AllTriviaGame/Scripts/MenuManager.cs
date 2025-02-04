using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MenuManager : MonoBehaviour
{
    private void OnEnable(){
        PanelEvents.OnPanelManagerInitialized += ShowNuevaPantalla;
    }

    private void OnDisable() {
        PanelEvents.OnPanelManagerInitialized += ShowNuevaPantalla;
    }

    private void ShowNuevaPantalla(){
        PanelManager.Instance.ShowPanel("NuevaPantalla");
    }

}
