using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hola mundo");
        Debug.Log("Todo parece ir bien");
        Debug.Log("Parece que algo esta queriendo salir mal");
        print("Creo que no, todo esta bien");
        Debug.LogWarning("No, no, espera!, Creo que si esta saliendo algo mal");
        Debug.Log("Olvida, no parece ser nada malo");
        Debug.LogError("Vaya! al parecer si estaba algo mal :'D");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
