using UnityEngine;

public class Troll : EnemyBase
{
    private void Start()
    {
        name = "Troll";
        health = 200f;
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log("Troll slaat met enorme kracht!");
    }

    public override void TakeDamage(float damage)
    {
        health += 5f; // regenereert eerst
        Debug.Log("Troll regenereert 5 HP!");

        base.TakeDamage(damage);
    }
}
