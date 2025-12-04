using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    // 1. Fields
    [SerializeField] private List<InventoryItem> _items = new List<InventoryItem>();

    [SerializeField] private WeaponItem _weaponPrefab;
    [SerializeField] private PotionItem _potionPrefab;
    [SerializeField] private KeycardItem _keycardPrefab;

    // 4. Unity Methods
    private void Update()
    {
        HandleInput();
    }

    // 5. Private Methods
    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            PickupItem(_weaponPrefab);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            PickupItem(_potionPrefab);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            PickupItem(_keycardPrefab);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            DropItem("Weapon");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            DropItem("Potion");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            DropItem("Keycard");
        }
    }

    private void PickupItem(InventoryItem itemPrefab)
    {
        InventoryItem newItem = Instantiate(itemPrefab);
        newItem.OnPickup();

        _items.Add(newItem);
        PrintInventoryState();
    }

    private void DropItem(string itemType)
    {
        InventoryItem item = _items.Find(i => i.ItemName.Contains(itemType));

        if (item == null)
        {
            Debug.Log($"No {itemType} in inventory.");
            return;
        }

        item.OnDrop();
        _items.Remove(item);
        Destroy(item.gameObject);

        PrintInventoryState();
    }

    private void PrintInventoryState()
    {
        int weapons = 0;
        int potions = 0;
        int keycards = 0;

        foreach (var item in _items)
        {
            if (item is WeaponItem) weapons++;
            if (item is PotionItem) potions++;
            if (item is KeycardItem) keycards++;
        }

        Debug.Log("--- Inventory ---");
        Debug.Log($"Weapons: {weapons}");
        Debug.Log($"Potions: {potions}");
        Debug.Log($"Keycards: {keycards}");
        Debug.Log("-----------------");
    }
}