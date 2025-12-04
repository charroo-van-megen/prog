using UnityEngine;

public abstract class InventoryItem : MonoBehaviour
{
    [SerializeField] protected string _itemName;

    public string ItemName => _itemName;

    public virtual void OnPickup()
    {
        Debug.Log($"Picked up: {_itemName}");
    }

    public virtual void OnDrop()
    {
        Debug.Log($"Dropped: {_itemName}");
    }
}
