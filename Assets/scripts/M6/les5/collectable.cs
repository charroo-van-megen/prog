using UnityEngine;
using System;

public abstract class Collectable : MonoBehaviour
{
    // Event om de manager te informeren
    public static Action<Collectable> OnCollected;

    // Abstracte methode: verplicht voor elke subclass
    public abstract void OnCollect(GameObject collector);

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        OnCollect(other.gameObject);

        // Informeer manager
        OnCollected?.Invoke(this);

        Destroy(gameObject);
    }
}
