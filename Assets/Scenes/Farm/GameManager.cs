using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {

        Chicken chicken = new Chicken("Chicken Yamada",10,20,0);//�������Ѻ���������ҧ��� �����ᴧ������ա 
        
        chicken.Feed("corn");
        chicken.MakeSound();
        chicken.Sleep();
        chicken.GetStatus();


        Cow cow = new Cow("MoMoYui Gahama",30,30,0);

        cow.Feed("grass");
        cow.MakeSound();
        cow.Moo();
        cow.GetStatus();
    }
}
