using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guia3 : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;
    string mayor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EscribirHolaMundoEnConsola();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //EscribirCadenaEnConsola();
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            MostrarNumerosRandomENtre(1, 29);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            mayor = MayordeTres(num1, num2, num3).ToString();
            EscribirCadenaEnConsola(mayor);
        }

    }

    //Definir una funcion que escriba en consola "Hola Mundo!"
    //Invocar la funcion con la barra espaciadora.
    void EscribirHolaMundoEnConsola()
    {
        Debug.Log("Hola Mundo");
    }

    //Definir una funcion que escriba en consola la cadena pasada por parámetro.
    void EscribirCadenaEnConsola(string cadena)
    {
        Debug.Log(cadena);
    }

    void MostrarNumerosRandomENtre(int min, int max)
    {
        Debug.Log(Random.Range(min,max+1));
    }

    //Definir una función que reciba tres enteros y devuelva el mayor de ellos. Si son iguales retornar -1.
    //Mostrar el dato devuelto en la consola usando la función 1.2.
    int MayordeTres(int a, int b, int c)
    {
        int greater = -1;

        if (a > b)
        {
            greater = a;
        }

        else
        {
            greater = b;
        }

        if (c > greater)
        {
            greater = c;
        }

        return greater;
    }
}
