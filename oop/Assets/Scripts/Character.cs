using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    public string name;
    protected float damage; // damage es privada pero queremos que sea publica a las clases hija, por lo que es PROTECTED
    public float health;
    protected Sprite _sprite;
    public Color color;


    public Character(string name, float damage, Sprite sprite)
    {
        this.name = name;
        this.damage = damage;
        _sprite = sprite;

    }

    public Sprite GetSprite() { return _sprite; }
    public float GetDamage()
    {
        return damage;
    }

    public abstract float Attack(); //-> METODO ABSTRACTO, es un comportamiento que se especifica en mago, cowboy

    public virtual float Heal() // VIRTUAL permite a los hijos sobreescribir el metodo sin que el metodo sea abstracto 
    {
        Debug.Log("Character se cura");

        //if(health > 100)
        //{
        //    return 100;
        //}
        //else if(health < 0)
        //{                               -> esto es equivalente a la linea siguiente solo que con ifs
        //    return 0;
        //}
        //else
        //{
        //    return health;
        //}

        health = Mathf.Clamp(health, 0, 100); // clamp devuelve el valor entre en minimo y maximo, si lo sobrepasa por el lado izq te devuelve el minimo y si lo sobrepasa por el dech te duvuelve el maximo.
        return health;
    }
}
