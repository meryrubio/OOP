using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class PlayerMovement : MonoBehaviour
{
    public GameObject[] playerSprites;
    private Rigidbody2D _rb;
    private Vector2 _dir;
    public KeyCode leftKey = KeyCode.A, rightKey = KeyCode.D;
    public float speed;

    private SpriteRenderer spriteRenderer;
    public Character character;

    SpriteRenderer rend;
    Animator animator;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        switch(GameManager.instance.characterType)
        {
            case CharacterType.WIZARD:
                character = new Wizard(1);
                break;
            case CharacterType.COWBOY:
                character = new Cowboy();
                break;
        }

        spriteRenderer.sprite = character.GetSprite();

        ////programamos un if para elegir para la funcion del boton para elegir el personaje
        //if (GameManager.instance.characterType == CharacterType.WIZARD)
        //{
        //    character = new Wizard(1.5f);
        //}
        //else if (GameManager.instance.characterType == CharacterType.COWBOY)
        //{
        //    character = new Cowboy();
        //}


        //rend.sprite = character.GetSprite();


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
