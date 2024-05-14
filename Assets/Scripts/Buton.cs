using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buton : MonoBehaviour
{
    public TMP_InputField inputText;
    public TMP_Text textoNombre;
    public Image luz;
    public GameObject botonPLAY;
    private void Awake()
    {
        luz.color = Color.red;
    }
    private void Update()
    {
        if(textoNombre.text.Length < 4) // si el nombre tiene menos de 4 caracteres el boton estara en rojo y no te dejara darle a jugar
        {
            luz.color = Color.red;
            botonPLAY.SetActive(false);

        }
        else //cnd tenga mas de 4 se pondra el boton verde y podras jugar 
        {
            luz.color = Color.green;
            botonPLAY.SetActive(true);
        }
        
       
    }

    public void PLAY()
    {
        // PlayerPrefs.SetString("nombre1", inputText.text);
        SceneManager.LoadScene("Game"); //cnd le des a juagar se cambiara la escena 
    }
    public void loadcharacter(int charactername)
    {
        GameManager.instance.characterType = (CharacterType)charactername;
    }

    public void LoadScene(string sceneName)
    {
        TMP_Dropdown dropdown = FindObjectOfType<TMP_Dropdown>();
        GameManager.instance.characterType = (CharacterType)dropdown.value;
        GameManager.instance.LoadScene(sceneName);
    }
}
