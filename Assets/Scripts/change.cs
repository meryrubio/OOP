using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour
{
    public static change Intance;
    private void Awake()
    {
        if (change.Intance == null) 
        {
            change.Intance = this;
            DontDestroyOnLoad(this.gameObject); // El personaje no se destruye entre escenas
        }
        else
        {
            Destroy(gameObject); // si ya se encuentra esa personaje en la secena si se ra destruido al cambiar de escena
        }
    }
}
