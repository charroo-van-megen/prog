using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public List<GameObject> enemies = new List<GameObject>();
    private float elapsed = 0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            SpawnMultiple(100);
        }

        elapsed += Time.deltaTime;
        if (elapsed > 1f)
        {
            SpawnMultiple(3); // elke seconde 3 enemies
            elapsed = 0f;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            ClearAll();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            StartCoroutine(RemoveOneByOne());
        }
    }

    void SpawnMultiple(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-10f, 10f), 0.5f, Random.Range(-10f, 10f));
            GameObject e = Instantiate(enemyPrefab, pos, Quaternion.identity);
            enemies.Add(e);
        }
    }

    void ClearAll()
    {
        foreach (GameObject e in enemies)
        {
            if (e != null) Destroy(e);
        }
        enemies.Clear();
    }

    IEnumerator RemoveOneByOne()
    {
        while (enemies.Count > 0)
        {
            GameObject e = enemies[0];
            enemies.RemoveAt(0);
            if (e != null) Destroy(e);
            yield return new WaitForSeconds(0.1f); // pas de delay aan als je langzamer/snelle removal wil
        }
    }
}
