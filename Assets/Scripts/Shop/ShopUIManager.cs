using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopUIManager : MonoBehaviour
{
    public Text goldDisplayer;
    public Text[] itemName = new Text[4];
    public Text[] itemPrice = new Text[4];
    public Item[] items;

    public bool shopInven = true;   //true일때 상점, false 일때 인벤토리

    void Update()
    {
        items = DataController.Instance.items.ToArray();
        goldDisplayer.text = DataController.Instance.gold + "";
        for(int i=0; i<items.Length; i++)
        {
            itemName[i].text = items[i].itemName;
        }

        if(shopInven == true)
        {
            for (int i = 0; i < items.Length; i++)
            {
                itemPrice[i].text = items[i].itemPrice + "";
            }
        }
        else
        {
            itemPrice[0].text = DataController.Instance.healItem + " 개 보유";
            itemPrice[1].text = DataController.Instance.cleanItem + " 개 보유";
            itemPrice[2].text = DataController.Instance.expItem + " 개 보유";
            itemPrice[3].text = DataController.Instance.etcItem + " 개 보유";
        }
       
    }
}
