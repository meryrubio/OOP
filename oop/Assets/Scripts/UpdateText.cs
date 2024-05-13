using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //avisar al código de que vas a utlizar otro código que esta en otra localización
using UnityEngine.SocialPlatforms.Impl;

public class NewBehaviourScript : MonoBehaviour
{
    //public GameManager.GameManagerVariables variable;

    private TMP_Text textComponent;
    // Start is called before the first frame update
    private void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {

        //switch (variable) //
        //{
        //    case GameManager.GameManagerVariables.HEAL:
        //        textComponent.text = "Current Heal: " + GameManager.instance.GetHeal().ToString("0/100"); // se añade el tostring para que devuelva una representacion de la barra de tiempo con solo dos decimales
        //        break;
          

    }

}

