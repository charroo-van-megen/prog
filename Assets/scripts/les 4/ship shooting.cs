using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    [Header("Shooting Settings")]
    public GameObject laserPrefab;
    public Transform shootPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (laserPrefab != null && shootPoint != null)
        {
            GameObject laser = Instantiate(laserPrefab, shootPoint.position, shootPoint.rotation);
            Debug.Log("Laser fired!");
        }
    }
}
