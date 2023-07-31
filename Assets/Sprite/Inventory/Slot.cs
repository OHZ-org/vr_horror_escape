using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Item1 item;
    public Image itemImage;


    private void SetColor(float _alpha)
    {
        Color color = itemImage.color;
        color.a = _alpha;
        itemImage.color = color;
    }
    public void AddItem(Item1 _item)
    {
        item = _item;
        itemImage.sprite = item.itemImage;
        SetColor(1);
    }

}
