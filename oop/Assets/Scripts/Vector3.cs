using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RPMI // esto es para evitar la colision de nombres (CONSTRUCTOR)
{
    public class Vector3 : MonoBehaviour
    {
        private string name;
        public float x, y, z;

        public Vector3() // cada vector es un Constructor
        {
            name = "V3_DEFAULT";
            x = 0;
            y = 0;
            z = 0;

        }

        public Vector3(string NAME, float X, float Y)
        {
            this.name = NAME;
            this.x = X;
            this.y = Y;
            z = 0;
        }

        public Vector3(string NAME, float X, float Y, float z)
        {
            this.name = NAME;
            this.x = X;
            this.y = Y;
            this.z = z;
        }
        public float Modulo() // hallar el modulo del vector -> pitagoras
        {
            float mod = Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2) + Mathf.Pow(z, 2)); //Sqrt -> Square roote, raiz cuadrada/ Pow -> potencia

            return mod;
        }

        public void Add(RPMI.Vector3 other) // estamos hacienod que lo vectores se sumen
        {
            x += other.x;
            y += other.y;
            z += other.z;

        }

        public void Add(float x, float y, float z) //Overload -> sobrecargar: definirlo varias veces pero con diferentes argumentos.
        {
            this.x += x;
            this.y += y;
            this.z += z;
        }
        public void Mul(float esc)// multiplicar el vector por un escalar
        {
            x *= esc;
            y *= esc;
            z *= esc;

        }

        public string GetName()
        {
            return name;
        }


    }
}

