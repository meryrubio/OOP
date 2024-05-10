using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sukamon : Character
{
    public Sukamon() : base("Sukamon", 1, Resources.Load<Sprite>("Sprites/Sukamon"))
    {
        //por la estructura de ->public Character(string name, float damage, Sprite sprite) sabemos que se name: Sukamon, y el float damage: 1

    }
    public override float Attack()
    {
        if (health < 5)
        {
            return damage = 100;
        }
        else
        {
            return damage;
        }
    }

    //public override float Heal()
    //{

    //}
}

