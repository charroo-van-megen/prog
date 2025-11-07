using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    [SerializeField] private int maxHealth = 5;
    [SerializeField] private float moveSpeed = 3f;

    private int currentHealth;
    private bool movingRight = true;
    private float leftLimit = -10f;
    private float rightLimit = 10f;

    public int Health => currentHealth; // Read-only
    public float MoveSpeed
    {
        get => moveSpeed;
        set => moveSpeed = Mathf.Abs(value); // altijd positief
    }

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        float direction = movingRight ? 1 : -1;
        transform.Translate(Vector3.right * direction * moveSpeed * Time.deltaTime);

        if (transform.position.x >= rightLimit)
            movingRight = false;
        else if (transform.position.x <= leftLimit)
            movingRight = true;
    }

    // 🔹 Add this method — it’s what your Brute and Elf are missing
    protected void SetMaxHealth(int value)
    {
        maxHealth = Mathf.Abs(value);
        currentHealth = maxHealth;
    }

    public virtual void TakeDamage(int damage)
    {
        damage = Mathf.Abs(damage);
        currentHealth -= damage;
        Debug.Log(gameObject.name + " took " + damage + " damage. Health now: " + currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        Debug.Log(gameObject.name + " is dead!");
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            TakeDamage(1);
            Destroy(other.gameObject);
        }
    }
}
