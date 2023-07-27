using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Item", menuName = "New Item/item")]
public class Item1 : ScriptableObject
{
    public string itemName;
    public ItemType itemType;
    public Sprite itemImage;
    public GameObject itemPrefab;

    public string objectType;

    public enum ItemType
    {
        Equipment,
        Used,
        ETC
    }    
}
