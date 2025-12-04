using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public ItemTemplate[] itemTemplates;

    private List<Item> items = new List<Item>();

    public ItemType filterType;

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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            List<Item> filtered = GetItemsByType(filterType);
            Debug.Log("---- Filter Result ----");

            foreach (Item item in filtered)
            {
                Debug.Log(item.Describe());
            }
        }

        // BONUS
        if (Input.GetKeyDown(KeyCode.S))
        {
            SellMode = true;
            Debug.Log("Sell mode activated! Press W for Weapon, P for Potion, A for Armor...");
        }

        if (SellMode)
        {
            if (Input.GetKeyDown(KeyCode.W)) Sell(ItemType.Weapon);
            if (Input.GetKeyDown(KeyCode.P)) Sell(ItemType.Potion);
            if (Input.GetKeyDown(KeyCode.A)) Sell(ItemType.Armor);
        }
    }

    private bool SellMode = false;

    void Sell(ItemType type)
    {
        for (int i = items.Count - 1; i >= 0; i--)
        {
            if (items[i].itemType == type)
            {
                Debug.Log($"Sold {items[i].itemName} for {items[i].sellPrice} gold");
                items.RemoveAt(i);
                SellMode = false;
                return;
            }
        }

        Debug.Log("No item of that type to sell!");
        SellMode = false;
    }
}
