using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushGenerator : MonoBehaviour
{
   
    public GameObject bushPrefab; // prefab del arbusto
    public int rows = 5; // Número de filas
    public int cols = 5; // Número de columnas
    public float spacing = 2f; // espaciado entre arbustos

    public void Start()
    {
        GenerateBushes();
    }
    void GenerateBushes()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Vector3 spawnPosition = new Vector3(row * spacing, col * spacing, 0f); // Posición de instanciación
                spawnPosition += transform.position; // ajustar posición 
                Instantiate(bushPrefab, spawnPosition, Quaternion.identity); // Instanciar el arbusto en la posición 

            }
        }
    }
  
}
