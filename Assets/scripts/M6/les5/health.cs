using UnityEngine;

public class HealthPickup : Collectable
{
    public override void OnCollect(GameObject collector)
    {
        Debug.Log("Health restored!");
        StatsManager.Instance.AddHealth(20);
    }
}
