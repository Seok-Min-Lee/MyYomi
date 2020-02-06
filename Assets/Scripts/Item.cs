using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item : MonoBehaviour
{
    public string itemName;
    public string itemDesc;
    public int itemPrice;
    public int itemCount;
    public Sprite sprite;

    public Item(string itemName, string itemDesc, int itemPrice)
    {
        this.itemName = itemName;
        this.itemDesc = itemDesc;
        this.itemPrice = itemPrice;
        itemCount = 1;
        sprite = Resources.Load("images/" + itemName, typeof(Sprite)) as Sprite;
    }
}
