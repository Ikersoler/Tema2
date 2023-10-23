using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
    [SerializeField] private float angulo1;
    [SerializeField] private float angulo2;
    [SerializeField] private float angulo3;


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
        if (intnum1 % intnum2 == 0)
        {
            Debug.Log(message: $"{intnum1} es divisible entre {intnum2}");
        }
        else
        {
            Debug.Log(message: $"{intnum1} NO es divisible entre {intnum2}");

        }


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

        if (mes == 1 && dias >=1 && dias < 20)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es capricornio");
        }
        else if (mes == 1 && dias >= 20 && dias < 32)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es acuario ");

        }
        else if (mes == 2 && dias >= 1 && dias < 19)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es acuario ");

        }
        else if (mes == 2 && dias >= 19 && dias < 29)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es piscis ");

        }
        else if (mes == 3 && dias >= 1 && dias < 21)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es piscis ");

        }
        else if (mes == 3 && dias >= 21 && dias < 32)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es aries ");

        }
        else if (mes == 4 && dias >= 1 && dias < 20)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es aries ");

        }
        else if (mes == 4 && dias >= 21 && dias < 31)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es tauro ");

        }
        else if (mes == 5 && dias >= 1 && dias < 21)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es tauro ");

        }
        else if (mes == 5 && dias >= 21 && dias < 32)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es geminis ");

        }
        else if (mes == 6 && dias >= 1 && dias < 21)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es geminis ");

        }
        else if (mes == 6  && dias >= 21 && dias < 31)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es cancer ");

        }
        else if (mes == 7 && dias >= 1 && dias < 23)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es cancer ");

        }
        else if (mes == 7 && dias >= 23 && dias < 27)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es leo ");

        }
        else if (mes == 8 && dias >= 1 && dias < 23)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es leo ");

        }
        else if (mes == 8 && dias >= 23 && dias < 32)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es virgo ");

        }
        else if (mes == 9 && dias >= 1 && dias < 23)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es virgo ");

        }
        else if (mes == 9 && dias >= 23 && dias < 31)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es libra ");

        }
        else if (mes == 10 && dias >= 1 && dias < 20)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es libra ");

        }
        else if (mes == 10 && dias >= 23 && dias < 32)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es escorpio ");

        }
        else if (mes == 11 && dias >= 1 && dias < 22)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es escorpio ");

        }
        else if (mes == 11 && dias >= 22 && dias < 31)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es sagitario ");

        }
        else if (mes == 12 && dias >= 1 && dias < 22)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es aries ");

        }
        else if (mes == 12 && dias >= 22 && dias < 32)
        {
            Debug.Log(message: $"tu horoscopo sehun el mes es capricornio ");

        }
        else
        {
            Debug.Log(message: "no crees en el horoscopo");

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

        if(edad>=18 && edad < 65)
        {
            if (menbresia == "gold")
            {
                Debug.Log(message: $"tienes un descuento de 75%");
            }
            if (menbresia == "silver")
            {
                Debug.Log(message: $"tienes un descuento de 50%");
            }

            if (menbresia == "bronze")
            {
                Debug.Log(message: $"tienes un descuento de 25%");
            }
        }
        else if (edad > 65)
        {
            if (menbresia == "gold")
            {
                Debug.Log(message: $"tienes un descuento de 50%");
            }
            if (menbresia == "silver")
            {
                Debug.Log(message: $"tienes un descuento de 25%");
            }

            if (menbresia == "bronze")
            {
                Debug.Log(message: $"tienes un descuento de 15%");
            }
        }
        else if(edad < 18)
        {
            Debug.Log(message: $"no puedes comprar en esta tienda porque heres menor");
        }



        //ejercicio 10

        if (angulo1 + angulo2 + angulo3 == 180)
        {
            Debug.Log(message:"la suma de estos angulos puedens ser los angulos internos de un triangulo");
        }
        else if (angulo1 + angulo2 + angulo3 == 180)
        {
            Debug.Log(message: "la suma de estos angulos NO puedens ser los angulos internos de un triangulo");
        }


    }

}
