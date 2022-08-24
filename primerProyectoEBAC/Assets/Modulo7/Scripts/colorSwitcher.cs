using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorSwitcher : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    bool sphereSwitch;
    bool cubeSwitch;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate() {

        switch (cubeSwitch) {
            case true:
                cube.GetComponent<MeshRenderer>().material.color = Color.white;
                cubeSwitch = false;
                break;
            case false:
                cube.GetComponent<MeshRenderer>().material.color = Color.black;
                cubeSwitch = true;
                break;
        }

        switch (sphereSwitch) {
            case true:
                sphere.GetComponent<MeshRenderer>().material.color = Color.white;
                sphereSwitch = false;
                break;
            case false:
                sphere.GetComponent<MeshRenderer>().material.color = Color.black;
                sphereSwitch = true;
                break;
        }


    }
}
