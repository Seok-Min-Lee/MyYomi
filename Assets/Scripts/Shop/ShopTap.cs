using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTap : MonoBehaviour
{
    public ShopUIManager shop;
    public void OnClick()
    {
        shop.shopInven = true;
    }
}
