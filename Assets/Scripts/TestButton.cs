using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestButton : MonoBehaviour
{
    public string itemName;


    public void Start()
    {

    }

    public void OnClick()
    {
        if (DataController.Instance.currentHp <= 0)
        {
            DataController.Instance.currentHp = 0;
            return;
        }
        if(DataController.Instance.currentCp <= 0)
        {
            DataController.Instance.currentCp = 0;
            return;
        }

        DataController.Instance.currentExp += 2;
        DataController.Instance.currentHp--;
        DataController.Instance.currentCp--;

        if (DataController.Instance.currentExp >= DataController.Instance.fullExp)
        {
            levelUp();
        }
    }

    public void levelUp()
    {
        DataController.Instance.currentExp -= DataController.Instance.fullExp;
        DataController.Instance.level++;

        DataController.Instance.fullExp = (int)Mathf.Pow(DataController.Instance.expPow, DataController.Instance.level);
        DataController.Instance.fullHp = (int)Mathf.Pow(DataController.Instance.hpPow, DataController.Instance.level);
        DataController.Instance.currentHp = DataController.Instance.fullHp;
        DataController.Instance.currentCp = DataController.Instance.fullCp;
    }
}
