using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    static public void changeAnimation(int num)
    {
        GameObject.Find("Canvas").transform.GetChild(num).gameObject.SetActive(true);

        for(int i = 0; i < 5; i++)
        {
            if(i == num)
            {
                continue;
            }
            GameObject.Find("Canvas").transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
