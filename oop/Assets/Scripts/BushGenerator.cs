using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushGenerator : MonoBehaviour
{

    public GameObject bushPrefab; // El prefab del arbusto
    public int rows = 5; // Número de filas
    public int cols = 5; // Número de columnas
    public float spacing = 2f; // Espaciado entre los arbustos

    public void Update()
    {
        GenerateBushes();
    }
    void GenerateBushes()
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Vector3 spawnPosition = new Vector3(row * spacing, 0f, col * spacing); // Posición de instanciación
                spawnPosition += transform.position; // Ajustar posición global
                Instantiate(bushPrefab, spawnPosition, Quaternion.identity); // Instanciar el arbusto en la posición calculada
            }
        }
    }
  
}
