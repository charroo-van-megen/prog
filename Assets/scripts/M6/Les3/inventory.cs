using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public ItemTemplate[] itemTemplates;

    private List<Item> items = new List<Item>();

    public ItemType filterType;

    private bool SellMode = false;

    void Start()
    {
        foreach (ItemTemplate template in itemTemplates)
        {
            Item newItem = template.CreateInstance();
            items.Add(newItem);

            Debug.Log("ADDED: " + newItem.Describe());
        }
    }

    public List<Item> GetItemsByType(ItemType type)
    {
        List<Item> filtered = new List<Item>();

        foreach (Item item in items)
        {
            if (item.itemType == type)
                filtered.Add(item);
        }

        return filtered;
    }

    void Update()
    {
        // Filtering
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var filtered = GetItemsByType(filterType);
            Debug.Log("---- FILTERED ITEMS ----");

            foreach (Item i in filtered)
                Debug.Log(i.Describe());
        }

        // Sell mode
        if (Input.GetKeyDown(KeyCode.S))
        {
            SellMode = true;
            Debug.Log("SELL MODE → Press W (Weapon), P (Potion), A (Armor)");
        }

        if (SellMode)
        {
            if (Input.GetKeyDown(KeyCode.W)) Sell(ItemType.Weapon);
            if (Input.GetKeyDown(KeyCode.P)) Sell(ItemType.Potion);
            if (Input.GetKeyDown(KeyCode.A)) Sell(ItemType.Armor);
        }
    }

    private void Sell(ItemType type)
    {
        for (int i = items.Count - 1; i >= 0; i--)
        {
            if (items[i].itemType == type)
            {
                Debug.Log($"Sold {items[i].itemName} for {items[i].sellPrice}");
                items.RemoveAt(i);
                SellMode = false;
                return;
            }
        }

        Debug.Log("No items of that type found!");
        SellMode = false;
    }
}
