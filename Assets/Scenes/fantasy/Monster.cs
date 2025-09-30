using System;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.TextCore.Text;




public abstract class  monsters : Charcter
{


    private int lootReward;
    public int LootReward
    {
        get { return lootReward; }
        set
        {
            if (value < 0) { lootReward = 0; }
            else { lootReward = value; }
        }
    }

    public abstract int LootGold { get; }

    public override void ShowStute()
    {
        base.ShowStute();
        Debug.Log($"Monster Loot : {LootReward}");
    }
    public abstract void Roar();

    //show stute
    public int DropReward()
    {
        return lootReward;
    }
    public override void Attack(Charcter target)
    {
        //base.Attack(target);
        target.TakeDamage(AttackPower);
        Debug.Log($"{Name} trick {target.Name} for {AttackPower} damage");
    }

    public override void Attack(Charcter target, int bounsDamage)
    {
        target.TakeDamage((AttackPower * 2) + (bounsDamage / 2));
        Debug.Log($"Cri!!! {Name} charm {target.Name} for {AttackPower * 2} damage with {bounsDamage / 2} bouns damage!");
    }

    public override void OnDefeated()
    {

    }

   
}
