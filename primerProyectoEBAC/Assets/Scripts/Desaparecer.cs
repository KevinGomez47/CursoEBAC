using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desaparecer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        for(int i = 255; i < 255; i--) {
            this.gameObject.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 0, i); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
