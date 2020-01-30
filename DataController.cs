using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    private static DataController instance;

    public static DataController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<DataController>();

                if (instance == null)
                {
                    GameObject container = new GameObject("DataController");

                    instance = container.AddComponent<DataController>();
                }
            }
            return instance;
        }
    }

    public int expPow = 3;
    public int hpPow = 2;

    public int level
    {
        get
        {
            return PlayerPrefs.GetInt("Level", 1);
        }
        set
        {
            PlayerPrefs.SetInt("Level", value);
        }
    }
    public int currentExp
    {
        get
        {
            return PlayerPrefs.GetInt("CurrentExp");
        }
        set
        {
            PlayerPrefs.SetInt("CurrentExp", value);
        }
    }
    public int fullExp
    {
        get
        {
            return PlayerPrefs.GetInt("FullExp", (int)Mathf.Pow(expPow, level));
        }
        set
        {
            PlayerPrefs.SetInt("FullExp", value);
        }
    }
    public int currentHp
    {
        get
        {
            return PlayerPrefs.GetInt("CurrentHp");
        }
        set
        {
            PlayerPrefs.SetInt("CurrentHp", value);
        }
    }
    public int fullHp
    {
        get
        {
            return PlayerPrefs.GetInt("FullHp", (int)Mathf.Pow(hpPow, level));
        }
        set
        {
            PlayerPrefs.SetInt("FullHp", value);
        }
    }

    public int currentCp
    {
        get
        {
            return PlayerPrefs.GetInt("CurrentCp");
        }
        set
        {
            PlayerPrefs.SetInt("CurrentCp", value);
        }
    }

    public int fullCp
    {
        get
        {
            return PlayerPrefs.GetInt("FullCp", 10);
        }
    }

    public int gold
    {
        get
        {
            return PlayerPrefs.GetInt("Gold");
        }
        set
        {
            PlayerPrefs.SetInt("Gold", value);
        }
    }
    

    void Awake()
    {
    }
    void Start()
    {
        StartCoroutine("AutoHeal");
    }
    IEnumerator AutoHeal()
    {
        while (true)
        {
            if (currentHp < fullHp)
            {
                currentHp++;
            }
            yield return new WaitForSeconds(1.0f);
        }
    }
}
