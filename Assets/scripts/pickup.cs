using UnityEngine;
using System;   // Nodig voor Action

public class Pickup : MonoBehaviour
{
    // Action Event dat een bericht stuurt
    public static event Action OnPickupCollected;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Verstuur het bericht
            OnPickupCollected?.Invoke();

            // Pickup verdwijnt
            Destroy(gameObject);
        }
    }
}
