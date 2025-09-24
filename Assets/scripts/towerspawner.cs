using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public GameObject towerPrefab;
    public float spawnRange = 10f;
    public LayerMask floorLayer; // zet deze in Inspector op "Ground" layer (voor bonus)

    void Update()
    {
        // Basale random positie spawn bij muisklik
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = RandomPosition(-spawnRange, spawnRange);
            Instantiate(towerPrefab, pos, Quaternion.identity);
        }

        // BONUS: spawn op de plek waar je op de vloer klikt
        if (Input.GetMouseButtonDown(1)) // rechtsklik voorbeeld
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit, 100f, floorLayer))
            {
                Instantiate(towerPrefab, hit.point, Quaternion.identity);
            }
        }
    }

    private Vector3 RandomPosition(float min, float max)
    {
        float x = Random.Range(min, max);
        float z = Random.Range(min, max);
        float y = 0f; // op de grond
        return new Vector3(x, y, z);
    }
}
