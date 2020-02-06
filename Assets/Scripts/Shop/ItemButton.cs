using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButton : MonoBehaviour
{
    Item[] items;
    public ShopUIManager shop;

    void Update()
    {
        items = DataController.Instance.items.ToArray();
    }
    public void HealItem()
    {
        if (shop.shopInven == true) //상점 탭 눌렀을때만 구매되도록
        {
            if (DataController.Instance.gold >= items[0].itemPrice)
            {
                DataController.Instance.gold -= items[0].itemPrice;
                DataController.Instance.healItem++;
            }
        }
    }

    public void CleanItem()
    {
        if (shop.shopInven == true)
        {
            if (DataController.Instance.gold >= items[1].itemPrice)
            {
                DataController.Instance.gold -= items[1].itemPrice;
                DataController.Instance.cleanItem++;
            }
        }
    }

    public void expItem()
    {
        if (shop.shopInven == true)
        {
            if (DataController.Instance.gold >= items[2].itemPrice)
            {
                DataController.Instance.gold -= items[2].itemPrice;
                DataController.Instance.expItem++;
            }
        }
    }

    public void etcItem()
    {
        if (shop.shopInven == true)
        {
            if (DataController.Instance.gold >= items[3].itemPrice)
            {
                DataController.Instance.gold -= items[3].itemPrice;
                DataController.Instance.etcItem++;
            }
        }
    }
}

