using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorConditions : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public GameObject andCapsule;
    public GameObject orCapsule;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        var cubeColor = cube.GetComponent<MeshRenderer>().material.color;
        var sphereColor = sphere.GetComponent<MeshRenderer>().material.color;
        var orCapsuleColor = orCapsule.GetComponent<MeshRenderer>().material.color;
        var andCapsuleColor = orCapsule.GetComponent<MeshRenderer>().material.color;

        switch (this.name) {
            case "CapsuleOne":
                if (cubeColor == Color.white && sphereColor == Color.white) this.GetComponent<MeshRenderer>().material.color = Color.white;
                else this.GetComponent<MeshRenderer>().material.color = Color.black;
                break;
            case "CapsuleTwo":
                if (cubeColor == Color.white || sphereColor == Color.white) this.GetComponent<MeshRenderer>().material.color = Color.white;
                else this.GetComponent<MeshRenderer>().material.color = Color.black;
                break;
            case "CapsuleThree":
                if (andCapsuleColor == Color.white && orCapsuleColor == Color.white) this.GetComponent<MeshRenderer>().material.color = Color.white;
                else this.GetComponent<MeshRenderer>().material.color = Color.black;
                break;
        }
    }
}
