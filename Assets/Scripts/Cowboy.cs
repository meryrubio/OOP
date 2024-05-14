using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cowboy : Character //HERENCIA -> hijo : padre
{
    public Cowboy() : base("Cowboy", 15, Resources.Load<Sprite>("Sprites/cowboy")) // construimos padre
    {
        // construimos hijo
        
    }



    public override float Attack() // ->OVERRRIDE para que se pueda sobreescribir ya que en character attack es abstracto
    {
        Debug.Log("vaquero ataca");
        return Random.Range(damage, damage * 2); // como no tiene gorro (no hay variable hasHat) no influye en el ataque
    }

    public override float Heal() //para sobre escribir en un metodo virtual necesitamos override 
    {
        Debug.Log("cowboy se cura");
        health += 10;
        base.Heal(); //-> es una Repulsion, un bucle infinito// llamas al Heal de character
        return 10;
    }
}
