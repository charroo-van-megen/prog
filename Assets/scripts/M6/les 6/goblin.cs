using UnityEngine;

public class Goblin : EnemyBase
{
    private float evasionChance = 0.2f;

    private void Start()
    {
        name = "Goblin";
    }

    public override void TakeDamage(float damage)
    {
        if (Random.value < evasionChance)
        {
            Debug.Log("Goblin ontwijkt de aanval!");
            return;
        }

        base.TakeDamage(damage);
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log($"Goblin schiet pijlen op {target.name}!");
    }
}
