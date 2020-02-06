using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryTap : MonoBehaviour
{
    public ShopUIManager shop;
    public void OnClick()
    {
        shop.shopInven = false;
    }
}
