using System;

[Serializable]
public struct ItemStats
{
    public float damage;
    public float defense;
    public float weight;

    public ItemStats(float damage, float defense, float weight)
    {
        this.damage = damage;
        this.defense = defense;
        this.weight = weight;
    }
}
