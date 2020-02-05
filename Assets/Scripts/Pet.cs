using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject SetupPanel;

    public void OnMouseDown()
    {
        if (MenuPanel != null)
        {
            if (SetupPanel != null)
            {
                if (SetupPanel.activeSelf == false)
                {
                    bool isActive = MenuPanel.activeSelf;
                    MenuPanel.SetActive(!isActive);
                }
            }
        }   
    }
}
