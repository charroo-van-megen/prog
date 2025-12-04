using UnityEngine;

public class Item
{
    public string itemName;
    public ItemType itemType;
    public ItemStats stats;
    public int sellPrice;
    public bool isEquipped;

    public Item(string name, ItemType type, ItemStats itemStats, int price)
    {
        itemName = name;
        itemType = type;
        stats = itemStats;
        sellPrice = price;
        isEquipped = false;
    }

    public string Describe()
    {
        return $"{itemName} ({itemType})\n" +
               $"Damage: {stats.damage}, Defense: {stats.defense}, Weight: {stats.weight}\n" +
               $"Sell Price: {sellPrice}";
    }

    public void ToggleEquip()
    {
        isEquipped = !isEquipped;
    }
}
