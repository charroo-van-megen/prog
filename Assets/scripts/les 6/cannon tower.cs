using UnityEngine;

public class CannonTower : Tower6
{
    [SerializeField] private float explosionRadius = 5f;
    public float ExplosionRadius => explosionRadius; // alleen uitlezen

    void Start()
    {
        Initialize();
        Debug.Log($"CannonTower: Explosion radius = {ExplosionRadius}");

        Vector3 targetPosition = transform.position + transform.forward * Range;
        Shoot(targetPosition);
    }
}
