using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupButton : MonoBehaviour
{
    public GameObject SetupPanel;
    public GameObject MenuPanel;

    public void OpenPanel()
    {
        if (SetupPanel != null)
        {   
            if(MenuPanel != null)
            {
                MenuPanel.SetActive(false);
            }
            SetupPanel.SetActive(true);
        }
    }
}

