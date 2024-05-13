using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Vector2 _dir;
    public KeyCode leftKey = KeyCode.A, rightKey = KeyCode.D;

    Characters.Character charcater;

    SpriteRenderer rend;
    Animator animator;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        //programamos un if para elegir para la funcion del boton para elegir el personaje
        if (GameManager.instance.characterType == Characters.WIZARD)
        {
            character = new Characters.Wizard(speed, GetComponent<Rigidbody2D>());
        }
        else if (GameManager.instance.characterType == Characters.COWBOY)
        {
            character = new Characters.Cowboy(speed, GetComponent<Rigidbody2D>());
        }
       

        rend.sprite = character.GetSprite();
        

    }
    void Movement()
    {

        _dir = new Vector2(0, 0); // para que al principio se mueva sin rozamiento
                                  //mueve pj...

        if (Input.GetKey(leftKey) || Input.GetKey(KeyCode.LeftArrow))
        {
            _dir = new Vector2(-1, _dir.y);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _dir = new Vector2(1, _dir.y);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            _dir = new Vector2(_dir.x, 1);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            _dir = new Vector2(_dir.x, -1);
        }
    }
}
