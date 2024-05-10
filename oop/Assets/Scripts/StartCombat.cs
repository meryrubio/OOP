using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCombat : MonoBehaviour
{
    public GameObject enemyPrefab;
    // Start is called before the first frame update
    public void StartCombatGame()
   {
        Debug.Log("¡Combate!");

        Vector3 enemySpawnPosition = transform.position + new Vector3(0, 5, 0); // 5 unidades adelante del arbusto
        Instantiate(enemyPrefab, enemySpawnPosition, Quaternion.identity);
    }

   
}
