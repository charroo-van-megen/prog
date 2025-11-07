using UnityEngine;

public class Tower6 : MonoBehaviour
{
    [SerializeField] private float range = 15f;       // zichtbaar in Inspector, niet public
    [SerializeField] private float fireRate = 1f;
    [SerializeField] private GameObject projectilePrefab;

    // Alleen uitleesbaar vanuit andere scripts (read-only)
    public float Range => range;
    public float FireRate => fireRate;

    protected virtual void Initialize()
    {
        Debug.Log($"Tower6 initialized. Range: {range}, FireRate: {fireRate}");
    }

    public void Shoot(Vector3 targetPosition)
    {
        Debug.Log("Tower6 shooting at: " + targetPosition);
        SpawnProjectile(targetPosition);
    }

    protected void SpawnProjectile(Vector3 targetPosition)
    {
        if (projectilePrefab == null) return;

        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
        Projectile proj = projectile.GetComponent<Projectile>();

        if (proj != null)
        {
            proj.Seek(targetPosition);
        }
    }
}
