using UnityEngine;

public class Dragon : monsters
{
    public override int LootGold => 50;

    
    public void InitializeDragon(string name)
    {
        base.Init(name, 300 , 20);
    }
    public override void Roar()
    {
        Debug.Log($"Dragon Ahhhhhhhhhhhh");
    }
    public override void Attack(Charcter target)
    {
        base.Attack(target);
        Debug.Log($"{Name}fire ball!!!!!  deal  {AttackPower} damage");

    }
}
