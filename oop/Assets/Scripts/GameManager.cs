using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public enum CharacterType //tipo enumerado, le puede poner nombres a los numeros: el 0=wizard, 1= cowboy
{
    WIZARD, COWBOY
}
public enum GameManagerVariables { HEAL, ATTACK }

public class GameManager : MonoBehaviour
{
    private int heal;

    public static GameManager instance; // accesible a todo (variable estática) SINGLETON
    public CharacterType characterType;

    public static object GameManagerVariables { get; internal set; }

    private void Awake()
    {
        if (!instance)// si instance no tiene info
        {
            instance = this; //si isma llega a la fiesta y ve que no hay nadie guapo isma se queda en la fiesta / instance se asigna a este objeto
            DontDestroyOnLoad(gameObject);// para que no se destruya en la carga de escenas
        }
        else // si ya hay alguin mas guapo antes que isma / si instance tiene info
        {
            Destroy(gameObject); // isma se va / se destruye el gameobject, para que no haya dos o mas gms en el juego
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //callback -- funcion que se va  a llamar en el onclick() de los botones
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        /* AudioManager.instance.ClearAudios();*/ // oye, audioManager, limpia todos los sonidos que estan sonando
    }


    public void ExitGame()
    {
        Debug.Log("EXIT!!");
        Application.Quit();// cierra la aplicación
    }

    public void GetHeal(int heal)
    {
       //return heal;
    }
}
