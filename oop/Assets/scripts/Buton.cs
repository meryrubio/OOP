using System.Collections;
using System.Collections.Generic;
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
        if(textoNombre.text.Length < 4)
        {
            luz.color = Color.red;
            botonPLAY.SetActive(false);

        }
        if (textoNombre.text.Length < 4)
        {
            luz.color = Color.green;
            botonPLAY.SetActive(true);
        }
    }
    public void PLAY()
    {
        PlayerPrefs.SetString("nombre1", inputText.text);
        SceneManager.LoadScene("");
    }
}
