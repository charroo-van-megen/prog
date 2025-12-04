using UnityEngine;

[CreateAssetMenu(menuName = "Game/Item Template")]
public class ItemTemplate : ScriptableObject
{
    public string itemName;
    public ItemType itemType;
    public ItemStats stats;
    public int basePrice;
    public Sprite icon;

    public Item CreateInstance()
    {
        return new Item(itemName, itemType, stats, basePrice);
    }
}
