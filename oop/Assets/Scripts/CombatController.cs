using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;

    private bool playerTurn = true;
    private bool combatEnded = false;
    void Update()
    {
               
                if (Input.GetMouseButtonDown(0)) // ataca
                {

                    //Attack(player, enemy);
                    playerTurn = false;
                    //Invoke("EnemyTurn", 1f); 
                }
                else if (Input.GetMouseButtonDown(1)) // curarse
                {
                    //Heal(player);
                    playerTurn = false;
                  /*  Invoke("EnemyTurn", 1f);*/ 
                }
            
           
                int randomAction = Random.Range(0, 2); // 0  para atacar, 1 curarse
                if (randomAction == 0)
                {
                    //Attack(enemy, player);
                }
                else
                {
                    //Heal(enemy);
                }
                playerTurn = true;
            
        
    }

}
