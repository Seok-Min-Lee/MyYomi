using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializationButton : MonoBehaviour
{
    public void OnClick()
    {
        PlayerPrefs.DeleteAll();
    }
}
