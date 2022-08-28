using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chars : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        char c = '9';
        int n = (int)char.GetNumericValue(c);
        Debug.Log(n);


        string hola = "Esta es una cadena";
        char holaInd = hola[3];

        Debug.Log(hola.Length);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
