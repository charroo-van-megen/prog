using UnityEngine;
using System.Collections.Generic;

public class CollectibleManager : MonoBehaviour
{
    private List<Collectable> collectibles = new List<Collectable>();

    private void OnEnable()
    {
        Collectable.OnCollected += HandleCollect;
    }

    private void OnDisable()
    {
        Collectable.OnCollected -= HandleCollect;
    }

    private void Start()
    {
        collectibles.AddRange(FindObjectsOfType<Collectable>());
        Debug.Log("Total collectibles: " + collectibles.Count);
    }

    private void HandleCollect(Collectable collected)
    {
        collectibles.Remove(collected);
        Debug.Log("Collectible collected! Remaining: " + collectibles.Count);
    }
}
