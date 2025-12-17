public class Item
{
    public string itemName;
    public ItemType itemType;
    public ItemStats stats;
    public int sellPrice;
    public bool isEquipped;

    public Item(string name, ItemType type, ItemStats stats, int price)
    {
        this.itemName = name;
        this.itemType = type;
        this.stats = stats;
        this.sellPrice = price;
        this.isEquipped = false;
    }

    public string Describe()
    {
        return $"{itemName} ({itemType})\n" +
               $"Damage: {stats.damage} | Defense: {stats.defense} | Weight: {stats.weight}\n" +
               $"Sell Price: {sellPrice}";
    }
}
