using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPrefab : MonoBehaviour
{
    public GameObject[] enemySprites; // Array de sprites de enemigos
   
    private SpriteRenderer spriteRenderer;
    public Vector3 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();



    }

    void Update()
    {
        // Genera un número aleatorio entre 0 y 10
        int randomNumber = Random.Range(0, 11);
        if (randomNumber % 2 != 0) // si es impar
        {
            Instantiate(enemySprites[0], spawnPos, Quaternion.identity);
        }
        else // Si es par
        {
            Instantiate(enemySprites[1], spawnPos, Quaternion.identity);
        }


    }
}
