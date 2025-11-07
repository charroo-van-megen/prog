using UnityEngine;

public class Brute : EnemyParent
{
    void Start()
    {
        SetMaxHealth(10);
        MoveSpeed = 1.5f;

        Debug.Log($"Brute spawned with {Health} HP and slow speed {MoveSpeed}");
    }
}
