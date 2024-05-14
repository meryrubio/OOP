using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Character
{
    public Goblin() : base("Goblin", 10, Resources.Load<Sprite>("Sprites/Goblin"))
    {
        //por la estructura de ->public Character(string name, float damage, Sprite sprite) sabemos que se name: Goblin, y el float damage: 10
    }
    public override float Attack()
    {
        if(health<20)
        {
            return damage * 3;
        }
        else
        {
            return damage;
        }

    }
}

//public override float Heal()
//{

//}
//}
