using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entregable3 : MonoBehaviour
{

    //ejercicio 1
    [SerializeField] private float num1;
    [SerializeField] private float num2;

    //ejercicio 2
    [SerializeField] private bool a;
    [SerializeField] private bool e;
    [SerializeField] private bool i;
    [SerializeField] private bool o;
    [SerializeField] private bool u;

    //ejercicio 3
    [SerializeField] private int intnum1;
    [SerializeField] private int intnum2;

    //ejercicio 4

    [SerializeField] private bool A;
    [SerializeField] private bool B;
    [SerializeField] private bool C;
    [SerializeField] private bool D;


    //ejercicio 5

    [SerializeField] private int dias;
    [SerializeField] private int mes;
    [SerializeField] private int año;

    //ejercicio 6 año chino

    //ejercicio 7 horoscopo

    //ejercicio 8 finde semana

    [SerializeField] private bool lunes = false;
    [SerializeField] private bool martes = false;
    [SerializeField] private bool miercoles = false;
    [SerializeField] private bool jueves = false;
    [SerializeField] private bool viernes = false;

    //ejercicio 9
    [SerializeField] private int edad;
    [SerializeField] private string menbresia;
    //ejercicio 10

    // Start is called before the first frame update
    void Start()
    {
        //ejercicio 1
        if (num1 <= num2)
        {
            Debug.Log(message: $"{num1} es menor que {num2}");
        }
        else
        {
            Debug.Log(message: $"{num1} es mayor que {num2}");
        }

        //ejercicio 2
        if (a)
        {
            Debug.Log(message:"es una vocal");
        }
        else if (e)
        {
            Debug.Log(message: "es una vocal");

        }
        else if (i) 
        {
            Debug.Log(message: "es una vocal");

        }
        else if (o)
        {
            Debug.Log(message: "es una vocal");

        }
        else if(u)
        {
            Debug.Log(message: "es una vocal");

        }
        else
        {
            Debug.Log(message: "es una CONSONANTE");

        }

        //ejercicio 3






        
        //ejercicio 4

        if (A)
        {
            Debug.Log(message: "excelente");
        }
        else if (B) 
        {
            Debug.Log(message: "notable");
        }
        else if (C)
        {
            Debug.Log(message: "aprobado");
        }
        else if (D)
        {
            Debug.Log(message: "suspenso");
        }

        //ejercicio 5

        if (mes == 1)
        {
            if(dias >= 1 && dias < 32)
            {
                Debug.Log(message: "es un dia valido"); 
            }
            else 
            {
                Debug.Log(message: "no es un dia valido");
                    
            }
        }
        else if (mes == 2)
        {
            if (dias >= 1 && dias < 29)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }

        }
        else if (mes == 3)
        {
            if (dias >= 1 && dias < 32)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 4)
        {
            if (dias >= 1 && dias < 31)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 5)
        {
            if (dias >= 1 && dias < 32)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 6)
        {
            if (dias >= 1 && dias < 31)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 7)
        {
            if (dias >= 1 && dias < 32)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 8)
        {
            if (dias >= 1 && dias < 32)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 9)
        {
            if (dias >= 1 && dias < 31)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 10)
        {
            if (dias >= 1 && dias < 32)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 11)
        {
            if (dias >= 1 && dias < 31)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }
        else if (mes == 12)
        {
            if (dias >= 1 && dias < 32)
            {
                Debug.Log(message: "es un dia valido");
            }
            else
            {
                Debug.Log(message: "no es un dia valido");

            }
        }


        //ejercicio 6

        if (año % 12 == 0)
        {
            Debug.Log(message: "es el año del mono"); 
        }
        else if (año % 12 == 1)
        {
            Debug.Log(message: "es el año del gallo");
        }
        else if (año % 12 == 2)
        {
            Debug.Log(message: "es el año del perro");
        }
        else if (año % 12 == 3)
        {
            Debug.Log(message: "es el año del cerdo");
        }
        else if (año % 12 == 4)
        {
            Debug.Log(message: "es el año del rata");
        }
        else if (año % 12 == 5)
        {
            Debug.Log(message: "es el año del buey");
        }
        else if (año % 12 == 6)
        {
            Debug.Log(message: "es el año del tigre");
        }
        else if (año % 12 == 7)
        {
            Debug.Log(message: "es el año del conejo");
        }
        else if (año % 12 == 8)
        {
            Debug.Log(message: "es el año del dragon");
        }
        else if (año % 12 == 9)
        {
            Debug.Log(message: "es el año del serpiente");
        }
        else if (año % 12 == 10)
        {
            Debug.Log(message: "es el año del caballo");
        }
        else if (año % 12 == 11)
        {
            Debug.Log(message: "es el año del cabra");
        }
        else if (año % 12 == 12)
        {
            Debug.Log(message: "es el año del mono");
        }
        else
        {
            Debug.Log(message: "no es el año de nada esta mal");

        }
        //ejercicio 7---------------------------------------------------------------------horoscopo

        if (mes == 1)
        {
            if (dias >=  && dias <= ) 
            {
                Debug.Log();
            }
        }

        //ejercicio 8

        if (lunes)
        {
            Debug.Log("Es lunes");
        }
        else if (martes)
        {
            Debug.Log("Es martes");
        }
        else if (miercoles)
        {
            Debug.Log("Es miércoles");
        }
        else if (jueves)
        {
            Debug.Log("Es jueves");
        }
        else if (viernes)
        {
            Debug.Log("Es viernes");
        }
        else
        {
            Debug.Log(message: "es fin de semanaaaaaa");
        }


        //ejercicio 9

        if (edad == 65 )
        {
            
        }


        //ejercicio 10





    }

}
