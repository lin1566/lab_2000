using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    //private List<monsters> monsters = new List<monsters>();
    public Hero hero;
    public List<monsters> monstersPrefabs;
    public List<Weapon> weaponsPrefabs;
    public monsters currentMonster;

    public List<monsters> monsters = new List<monsters>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        hero.Init("John_Hero", 1000, 10);
        hero.ShowStute();

        Weapon sword = Instantiate(weaponsPrefabs[0], new Vector3(-3, -1, 0),Quaternion.identity);
        Weapon club = Instantiate(weaponsPrefabs[1], new Vector3(-3, -1, 0),Quaternion.identity);

        sword.InitWeapon("sword", 10);
        club.InitWeapon("club", 7);

        monsters goblinObj  = Instantiate(monstersPrefabs[0]);
        Goblin goblinMonster = goblinObj.GetComponent<Goblin>();
        if (goblinMonster != null)
        {
            goblinMonster.InitializeGoblin("Little Goblin");
        }
        monsters.Add(goblinObj);

        monsters orcObj  = Instantiate(monstersPrefabs[1]);
        Orc orcMonster = orcObj.GetComponent<Orc>();
        if (orcMonster != null)
        {
            orcMonster.InitializeOrc("Medium Orc ");
        }
        monsters.Add(orcObj);

        monsters DragonObj  = Instantiate(monstersPrefabs[2]);
        Dragon DragonMonster = DragonObj.GetComponent<Dragon>();
        if (DragonMonster != null)
        {
            DragonMonster.InitializeDragon("king Dragon ");
        }
        monsters.Add(DragonObj);

        

        hero.EquipWeapon(sword);
        monsters[1].EquipWeapon(club);

        hero.Attack(monsters[1],hero.EquippedWeapon);
        monsters[1].Attack(hero, monsters[1].EquippedWeapon);

        foreach (monsters m in monsters)
        {
            m.ShowStute();
            m.Roar();
            m.Attack(hero, sword);
        
        }









        /*SpawnMonster(MonsterType.GirlInReallife);
        SpawnMonster(MonsterType.EGirl);
        SpawnMonster(MonsterType.Vtber);
        //Spwan GIRI
        /*currentMonster = Instantiate(monstersPrefabs[0]);
        currentMonster.Init("GirlInReallife", 200, 100);
        monsters.Add(currentMonster);

        //Spwan 2D Girl
        currentMonster = Instantiate(monstersPrefabs[1]);
        currentMonster.Init("EGirl", 100, 10);
        monsters.Add(currentMonster);

        //Spwan Vtber
        currentMonster = Instantiate(monstersPrefabs[2]);
        currentMonster.Init("Vtber", 200, 20);
        monsters.Add(currentMonster);*/
        /*
        foreach (var monster in monsters)
        {
            monster.ShowStute();
        }
        /*
        Debug.Log("*******Battle*******");

        //Attack
        currentMonster = monsters[0];
        hero.Attack(currentMonster);
        currentMonster.Attack(hero);
        hero.ShowStute();
        currentMonster.ShowStute();

        //GetGold
        Debug.Log($"{currentMonster.Name} is defeated!");
        hero.EarnGold(currentMonster.LootReward);
        hero.ShowStute();

        //BounsDamage
        hero.Attack(currentMonster, 10);
        currentMonster.Attack(hero, 10);
        hero.ShowStute();
        currentMonster.ShowStute();
    }

    /*public void SpawnMonster(MonsterType monstertype)
    {
        monsters monsterPrefab = monstersPrefabs[(int)monstertype];

        monsters monsterObj = Instantiate(monsterPrefab);

        monsterObj.Init(monstertype);
        monsters.Add(monsterObj);*/



    }

}
