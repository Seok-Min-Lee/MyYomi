using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStartButton : MonoBehaviour
{
    public GameObject StartPanel;
    public GameObject GamePanel;

    public void OnClickButton()
    {
        StartPanel.SetActive(false);
        GamePanel.SetActive(true);
    }
}
