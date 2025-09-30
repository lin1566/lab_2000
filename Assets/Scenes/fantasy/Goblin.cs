using UnityEngine;

public class Goblin : monsters
{
    public override int LootGold => 5;
    public void InitializeGoblin(string name)
    {
        base.Init(name, 100, 20);
    }
    public override void Roar()
    {
        Debug.Log($"Goblin Roar");
    }
    public override void Attack(Charcter target)
    {
        base.Attack(target);
        Debug.Log($"{Name}Quick stupid deal  {AttackPower} damage");

    }
}