using UnityEngine;

public class EnemyBase : MonoBehaviour
{
    protected float health = 100f;
    protected float speed = 2f;

    public virtual void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log($"{name} krijgt {damage} damage! HP: {health}");

        if (health <= 0)
        {
            Die();
        }
    }

    public virtual void Attack(GameObject target)
    {
        Debug.Log($"{name} valt aan!");
    }

    protected virtual void Die()
    {
        Debug.Log($"{name} is dood!");
        Destroy(gameObject);
    }
}
