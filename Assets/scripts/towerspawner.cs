using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public GameObject towerPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Linker muisknop
        {
            Vector3 pos = RandomPosition(-10f, 10f);
            Instantiate(towerPrefab, pos, Quaternion.identity);
        }
    }

    private Vector3 RandomPosition(float min, float max)
    {
        float x = Random.Range(min, max);
        float z = Random.Range(min, max);
        return new Vector3(x, 0f, z); // vloer op y=0
    }
}
