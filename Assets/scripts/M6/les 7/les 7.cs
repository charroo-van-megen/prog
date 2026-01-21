using UnityEngine;

public class CombatSystem : MonoBehaviour
{
    [System.Serializable]
    public class Combatant
    {
        public bool IsAlive;
        public bool IsStunned;
        public bool IsSlowed;

        public float AttackCooldown;
        public float Mana;
        public float Health;
        public bool WeaponEquipped;

        public bool HasStrengthBuff;
        public Vector3 Position;
    }

    private bool IsReadyToAttack(Combatant attacker, Combatant target)
    {
        if (attacker == null || target == null) return false;
        if (!attacker.IsAlive || !target.IsAlive) return false;
        if (attacker.AttackCooldown > 0f) return false;

        float distance = Vector3.Distance(attacker.Position, target.Position);
        if (distance >= 5f) return false;

        bool hasManaAttack = attacker.Mana >= 20f && attacker.WeaponEquipped;
        bool hasBuffAttack = attacker.Health > 30f && attacker.HasStrengthBuff;

        if (!hasManaAttack && !hasBuffAttack) return false;
        if (attacker.IsStunned || attacker.IsSlowed) return false;

        return true;
    }
}
