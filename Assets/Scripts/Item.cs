using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Item", menuName = "New Item/item")]
public class Item : ScriptableObject
{
    public string itemName; // 아이템의 이름
    public ItemType itemType; // 아이템의 유형
    public GameObject itemPrefab; // 아이템의 프리팹

    public enum ItemType{
        Coin,
        Heart,
        Magnet,
        GP // Grage period
    }
}
