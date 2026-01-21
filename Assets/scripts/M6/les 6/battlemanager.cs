using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    private List<EnemyBase> enemies = new List<EnemyBase>();
    private float playerHealth = 100f;

    private void Start()
    {
        enemies.Add(new GameObject("Zombie").AddComponent<Zombie>());
        enemies.Add(new GameObject("Goblin").AddComponent<Goblin>());
        enemies.Add(new GameObject("Dragon").AddComponent<Dragon>());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("PRESSED - SPACE");

            foreach (EnemyBase enemy in enemies)
            {
                if (enemy != null)
                    enemy.Attack(gameObject);
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("PRESSED - D");

            foreach (EnemyBase enemy in enemies)
            {
                if (enemy != null)
                {
                    enemy.TakeDamage(25f);
                    TakeDamageFromEnemy(10f);
                }
            }

            enemies.RemoveAll(e => e == null);
            CheckWinLose();
        }
    }

    private void TakeDamageFromEnemy(float damage)
    {
        playerHealth -= damage;
        Debug.Log($"BattleManager krijgt {damage} damage! HP: {playerHealth}");
    }

    private void CheckWinLose()
    {
        if (playerHealth <= 0)
        {
            Debug.Log("GAME OVER!");
            enabled = false;
        }
        else if (enemies.Count == 0)
        {
            Debug.Log("VICTORY!");
            enabled = false;
        }
    }
}
