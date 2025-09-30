
using System;
using UnityEngine;
public class Hero : Charcter
{
    public int Gold { get; private set; }

    private int maxGold = 999;

    /*
    private int gold;
    public int Gold
    {
        get { return gold; }
        set {
            if (value > 999) { gold = 999; }
            else if (value <= 0) { gold = 0; }
            else { gold = value; }
        }
    }
    */


    //create an object
    public void Init(string newName, int newHp, int newAttackPower)
    {
        base.Init(newName, newHp, newAttackPower);
        Gold = 0;
    }

    public override void ShowStute()
    {
        base.ShowStute();
        Debug.Log($"Hero have : {Gold} Gold");
    }
    public void EarnGold(int amount)
    {
        Gold = Mathf.Clamp(Gold + amount, 0, maxGold);
        Debug.Log($"{name} take {amount} gold with Monster| Gold : {Gold}");

    }

    public void Heal(int healAmount)
    {
        Health = Mathf.Clamp(Health, 0, maxHealth);
        Debug.Log($"{name} heal {healAmount} damage!; Hero Health : {Health}");
    }

    public override void Attack(Charcter target, Weapon equippedWeapon)
    {
        //base.Attack(target);
        target.TakeDamage(AttackPower);
        Debug.Log($"{Name} hits {target.Name} for {AttackPower} damage");
    }

    public override void Attack(Charcter target, int bounsDamage)
    {
        target.TakeDamage((AttackPower * 2) + (bounsDamage / 2));
        Debug.Log($"Cri!!! {Name} kick {target.Name} for {AttackPower * 2} damage with {bounsDamage / 2} bouns damage!");
    }
    public override void OnDefeated()
    {

    }

    public override void Attack(Charcter target)
    {
        throw new NotImplementedException();
    }
}
