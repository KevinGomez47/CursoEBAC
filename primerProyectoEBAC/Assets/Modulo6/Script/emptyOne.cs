using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emptyOne : MonoBehaviour
{
    private void Awake()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
