using UnityEngine;
using System;  // Nodig voor Action

public class Pickup : MonoBehaviour
{
    // 🔔 Action Event definitie
    public static event Action<int> OnPickupCollected;

    [SerializeField] private int scoreValue = 50; // standaard waarde, kun je aanpassen per prefab

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Event versturen + waarde meegeven
            OnPickupCollected?.Invoke(scoreValue);

            // Pickup verwijderen
            Destroy(gameObject);
        }
    }
}
