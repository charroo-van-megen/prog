public bool IsPlayerReadyToAttack(Player player)
{
    // Guard clauses: alle foute condities eerst afvangen
    if (player == null) return false;
    if (!player.IsAlive) return false;
    if (player.AttackCooldown > 0) return false;

    if (player.Target == null) return false;
    if (!player.Target.IsAlive) return false;

    float distance = Vector3.Distance(
        player.transform.position,
        player.Target.transform.position
    );

    if (distance >= 5f) return false;

    // Complexe logica opgesplitst en leesbaar gemaakt
    bool hasManaAttack = player.Mana >= 20 && player.WeaponEquipped;
    bool hasBuffAttack = player.Health > 30 && player.HasBuff("Strength");

    if (!hasManaAttack && !hasBuffAttack) return false;

    if (player.IsStunned) return false;
    if (player.IsSlowed) return false;

    // Happy path
    return true;
}
