using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class entregable3 : MonoBehaviour
{
    //ejercicio 1
    [SerializeField] private float num1;
    [SerializeField] private float num2;


    void Start()
    {

        //ejercicioo 1
        if (num1 > num2)
        {
            Debug.Log(message: $"{num1 } es mayor que {num2}");
        }
        else
        {
            Debug.Log(message: $"{num1}es menor que {num2}");
        }

        //ejercicio 2


    }


}
