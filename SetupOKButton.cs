using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupOKButton : MonoBehaviour
{
    public GameObject SetupPanel;

    public void ClosePanel()
    {
        if(SetupPanel != null)
        {
            bool isActive = SetupPanel.activeSelf;
            SetupPanel.SetActive(!isActive);
        }
    }
}
