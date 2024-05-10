using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. UI;

public class nombre : MonoBehaviour
{
    private GameObject nombre1;
    private void Start()
    {
        nombre1 = GameObject.FindGameObjectWithTag("nombre1"); //buscara el tag del texto 
        nombre1.GetComponent<Text>().text = PlayerPrefs.GetString("nombre1"); // pondra el nombre del usuario en el texto de la escena de juego 
    }
}
