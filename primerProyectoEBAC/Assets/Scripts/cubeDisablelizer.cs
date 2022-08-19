using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeDisablelizer : MonoBehaviour
{
    public GameObject disableMeCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        if(disableMeCube != null)
        {
            GameObject tempGameObj = Instantiate<GameObject>(disableMeCube);
            tempGameObj.name = "IDontHaveToMuchTimeEither";
            tempGameObj.transform.position = new Vector3(2.5f, -2.5f, 0);
            Destroy(tempGameObj, 2f);
        }
    }
}
