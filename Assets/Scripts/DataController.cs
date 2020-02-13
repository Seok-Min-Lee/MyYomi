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

    //경험치, hp 증가비율
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

    public int healItem
    {
        get
        {
            return PlayerPrefs.GetInt("healItem");
        }
        set
        {
            PlayerPrefs.SetInt("healItem", value);
        }
    }

    public int cleanItem
    {
        get
        {
            return PlayerPrefs.GetInt("cleanItem");
        }
        set
        {
            PlayerPrefs.SetInt("cleanItem", value);
        }
    }

    public int expItem
    {
        get
        {
            return PlayerPrefs.GetInt("expItem");
        }
        set
        {
            PlayerPrefs.SetInt("expItem", value);
        }
    }

    public int etcItem
    {
        get
        {
            return PlayerPrefs.GetInt("etcItem");
        }
        set
        {
            PlayerPrefs.SetInt("etcItem", value);
        }
    }

    public List<Item> items = new List<Item>();

    void Awake()
    {
    }
    void Start()
    {
        StartCoroutine("AutoHeal");

        items.Add(new Item("healItem", "사용즉시 hp 회복", 20000));
        items.Add(new Item("cleanItem", "사용즉시 cp 회복", 10000));
        items.Add(new Item("expItem", "사용즉시 exp 증가", 5000));
        items.Add(new Item("etcItem", "아무일도 일어나지 않음", 100));
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

    public void levelUp()
    {
        currentExp -= fullExp;
        level++;

        fullExp = (int)Mathf.Pow(expPow, level);
        fullHp = (int)Mathf.Pow(hpPow, level);
        currentHp = fullHp;
        currentCp = fullCp;
    }

    public Animator animator;
    public GameObject default1;
    public GameObject drity;

    public void ImageChange()
    {
        animator = GetComponent<Animator>();

        if (currentHp < currentHp / 1.5 / 1.5 && currentCp < 7)
        {
            default1.SetActive(true);
            drity.SetActive(false);
            /*animator.SetBool("default", true);*/
        }

        if (currentCp < 4)
        {
            drity.SetActive(true);
            default1.SetActive(false);
            /*animator.SetBool("dirty", true);*/
        }
    }

}
