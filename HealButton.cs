using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealButton : MonoBehaviour
{
    public void OnClick()
    {
        DataController.Instance.currentHp = DataController.Instance.fullHp;
    }
}
