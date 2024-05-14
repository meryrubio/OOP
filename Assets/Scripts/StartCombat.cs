using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartCombat : MonoBehaviour
{
    public Text playerCharacterNameText;
    public Text enemyCharacterNameText;

    void Start()
    {
        // Desactiva la interfaz al inicio
        gameObject.SetActive(false);
    }

    public void ShowCombatStart(Character playerCharacter, Character enemyCharacter)
    {
        // Muestra los nombres de los personajes en los Textos
        playerCharacterNameText.text = playerCharacter.name;
        enemyCharacterNameText.text = enemyCharacter.name;


        gameObject.SetActive(true);
    }
}



