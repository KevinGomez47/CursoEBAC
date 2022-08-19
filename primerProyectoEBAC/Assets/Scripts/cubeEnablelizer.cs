using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeEnablelizer : MonoBehaviour
{
    public GameObject enableMeCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        GameObject tempGameObj = Instantiate<GameObject>(enableMeCube);
        tempGameObj.name = "IDontHaveToMuchTime";
        tempGameObj.transform.position = new Vector3(-2.5f, -2.5f, 0);
        Destroy(tempGameObj, 2f);
    }
}
