using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    /*
    Sentencias de control (Ciclos)
    -> for : Se utiliza cuando sabemos la cantidad de veces que se repite el ciclo
    -> while : Se utiliza cuando no sabemos cuantas veces se repite el ciclo
    -> do while : se utiliza cuando sabemos que al menos se repetira una vez el ciclo
    -> arrays
        -> arrays unidimecionales
        -> arrays multidimencionales
            -> [0,1,2]
               [3,4,5]
               [6,7,9]
        -> arrays jagged
            -> [0,1,2,2,3,1]
               [3,4,5]
               [6,7,9,3,1]
    -> foreach : se utiliza para recorrer arreglos, es mucho más eficiente para ellos
    */

    // int iter = 0;
    // bool doIter = false;

    // array unidimensional
    int[] myArray = new int[5];

    // Los arreglos son inmutables, [x] es la cantidad de elentos dentro del array, para poderlo cambiar es necesario declararlos como nuevos
    string[] myStringArray = new string[7] {
        "Lunes",
        "Martes",
        "Miercoles",
        "Jueves",
        "Viernes",
        "Sabado",
        "Domingo"
    };

    // Arreglo multidimencional
    int[,] myMatrix = new int[3, 3] {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
    };

    // Arreglo jagged
    int[][] myJagged = new int[][] {
        new int[] {1, 2, 3},
        new int[] {4, 5},
        new int[] {7, 8, 9, 10, 11}
    };
    // Start is called before the first frame update
    void Start()
    {
        // loop for
        /*
        for(int i = 0; i < 10; i++) {
            Debug.Log(i);
        }
        */

        // loop while
        /*
        while (doIter) {
            Debug.Log(iter);
            iter++;
        }
        */

        // loop do while
        /*
        do {
            Debug.Log("Hola desde el Do");
        } while (doIter);
        */


        //Recorriendo el array con el for
        /*
        for(int i = 0; i < myStringArray.Length; i++) {
            Debug.Log(myStringArray[i]);
        };
        */
        //Recorriendo un arreglo multidimensional con for, la funcion GetLength(x) en su parametro x
        // nos devuelve la cantidad de indices de la dimensión que le estamos pasando del arreglo
        /*
        for(int dim = 0; dim < myMatrix.GetLength(0); dim++) {
            print("Dimensión " + dim);
            for (int ind = 0; ind < myMatrix.GetLength(1); ind++) {
                myMatrix[dim, ind] += 1;
                Debug.Log(myMatrix[dim, ind]);
            }
        }
        */

        //Recorriendo un arreglo de tipo Jagged
        /*
        for(int dim = 0; dim < myJagged.Length; dim++) {
            print("Dimensión " + dim);
            for(int ind = 0; ind < myJagged[dim].Length; ind++) {
                Debug.Log(myJagged[dim][ind]);
            };
        };
        */

        //Recoriendo el arreglo con el foreach
        /*
        foreach (var i in myStringArray) {
            Debug.Log(i);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
