using System;
using UnityEngine;

public abstract class Charcter : MonoBehaviour
{
    public Weapon EquippedWeapon { get; private set; }
    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value)) { name = "Unknow hero"; }
            else { name = value; }
        }
    }


    public int Health { get; protected set; }
    protected int maxHealth = 1000;

    /*private int health;
    public int Health
    {
        get { return health; }
        set
        {
            if (value >= 0) health = value;
            else health = 0;
        }
    }*/



    private int attackPower;
    public int AttackPower
    {
        get; set;
    }

    
    //create an object
    public virtual void Init(string newName, int newHp, int newAttackPower)
    {
        Name = newName;
        Health = newHp;
        AttackPower = newAttackPower;

    }

    public virtual void ShowStute()
    {
        Debug.Log($"Character name : {Name} | Character health : {Health} | Character Attack {AttackPower}");
    }


    public void TakeDamage(int damageValue)
    {
        //Health -= damageValue;
        Health = Mathf.Clamp(Health - damageValue, 0, maxHealth);
        //Debug.Log($"{name} take {damageValue} damage!; Health : {Health}");
        /*
        if (Health < 0) Health = 0; //Check Minimum
        else if  (Health > maxHealth) Health = maxHealth;//Check Maximum
        */

    }

    /*
    public virtual void Attack(Charcter target)
    {
        //Debug.Log($"{Name} attack {target.Name} for {AttackPower} damage");
        target.TakeDamage(AttackPower);
    }
    */

    public abstract void Attack(Charcter target);

    public abstract void Attack(Charcter target, int bounsDamage);

    public virtual void Attack(Charcter traget, Weapon weapon)
    { 
    int damage = AttackPower + weapon.BonusDamage;
        traget. TakeDamage (damage);
        Debug.Log($"{Name} use a {weapon.WeaponName}with bonus" +
            $"{weapon.BonusDamage}damage  total {damage} to {traget.Name }");
    }
    public abstract void OnDefeated();

    public bool IsAlive()
    {
        return Health > 0;
    }
    
    public void EquipWeapon(Weapon weapon)
    {
        EquippedWeapon = weapon;
    }

   

}
