using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holaMundo : MonoBehaviour
{

    int x;
    public GameObject mainCam;
    // Awake es la primer funcion que se ejecuta al dar play al juego
    private void Awake()
    {
        mainCam = this.gameObject;
        //print("Hola mundo desde Awake");
        //print("Hola mundo");
        //Debug.Log("Todo parece ir bien");
        //Debug.Log("Parece que algo esta queriendo salir mal");
        //print("Creo que no, todo esta bien");
        //Debug.LogWarning("No, no, espera!, Creo que si esta saliendo algo mal");
        //Debug.Log("Olvida, no parece ser nada malo");
        //Debug.LogError("Vaya! al parecer si estaba algo mal :'D");
        //x = x + 1;
        //Debug.Log("X es igual a " + x);
        
    }
    //Start se ejecuta justo despues de Awake
    void Start()
    {
        Debug.Log("Esta es la primer ejecución de Start");
    }

    // Update se ejecuta cada vez que comienzan a actualizar los cuadros de la pantalla
    void Update()
    {
        Debug.LogWarning("Se esta actualizando un cuadro");
    }
    // FixedUpdate se ejecuta cada 50 cuadros
    private void FixedUpdate()
    {
        Debug.LogError("Han pasado 50 cuadros");
    }
    // LateUpdate se ejecutada practicamente al finalizar la carga de los cuadros de la pantalla
    private void LateUpdate()
    {
        print("Esta finalizando la carga de un cuadro");
    }
    //OnEnable se ejecuta cuando un GameObject es activado.
    private void OnEnable()
    {
        Debug.Log(mainCam.name + " A sido activado");
    }
    // OnDisable se ejecuta cuando un GameObject es desactivado.
    private void OnDisable()
    {
        Debug.LogWarning(mainCam.name + " A sido desactivado");
    }
}
