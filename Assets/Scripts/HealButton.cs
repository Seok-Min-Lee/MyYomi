using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealButton : MonoBehaviour
{
    IEnumerator Eat()
    {
        for(int i = 0; i < 2; i++)
        {
            AnimationController.changeAnimation(3);

            yield return new WaitForSeconds(1.0f);
        }
    }

    public void OnClick()
    {
        DataController.Instance.currentHp = DataController.Instance.fullHp;
        StartCoroutine("Eat");
    }
}
