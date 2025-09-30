using UnityEngine;

public class Orc : monsters
{
    public override int LootGold => 10;
    public void InitializeOrc(string name)
    {
        base.Init(name, 200, 50);
    }
    public override void Roar()
    {
        Debug.Log($"Ord Roar ord ord");
    }
    public override void Attack(Charcter target)
    {
        base.Attack(target);
        Debug.Log($"{Name}Punch deal  {AttackPower} damage");

    }
}
