using UnityEngine;

public class CoinPickup : Collectable
{
    public override void OnCollect(GameObject collector)
    {
        Debug.Log("Coin collected!");
        StatsManager.Instance.AddScore(10);
    }
}
