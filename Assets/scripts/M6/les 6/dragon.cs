using UnityEngine;

public class Dragon : EnemyBase
{
    private void Start()
    {
        name = "Dragon";
        health = 1000f;
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log($"Dragon spuwt vuur en verkoolt {target.name}!");
    }
}
