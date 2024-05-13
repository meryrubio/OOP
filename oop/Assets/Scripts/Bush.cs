using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour
{
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    public void StartCombatGame()
    {
        Debug.Log("¡Combate!");

        Vector3 enemySpawnPosition = transform.position + new Vector3(0, 5, 0); // 5 unidades adelante del arbusto
        Instantiate(enemyPrefab, enemySpawnPosition, Quaternion.identity);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<PlayerMovement>()) 
        {
            int randomNumber = Random.Range(1, 11); // 
            if (randomNumber % 2 != 0) // si es impar
            {
                StartCombatGame();
            }
        }
    }
}
