using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createGO : MonoBehaviour
{
    public GameObject cubeFromScratch;
    public GameObject cubeSpawner;
    public int cubeAmount = 0;
    public float cubePos = -2.5f;
    public bool cubeDir = true;
    private void Awake()
    {
        GameObject tempGameObj = Instantiate<GameObject>(cubeFromScratch);
        tempGameObj.name = "newGOCube";
        tempGameObj.transform.position = new Vector3(-2.5f, 2.5f, 0);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cubeAmount++;
        GameObject tempGameObj = Instantiate<GameObject>(cubeSpawner);
        tempGameObj.name = "cubeNum" + cubeAmount;
        Destroy(tempGameObj, 0.3f);
        if (cubeDir == true)
        {
            tempGameObj.transform.position = new Vector3(cubePos, 2.5f, 0);
            cubePos++;
            if(cubePos == 100.5f)
            {
                cubeDir = false;
            }
        }
        else if (cubeDir == false)
        {
            tempGameObj.transform.position = new Vector3(cubePos, 2.5f, 0);
            cubePos--;
            if (cubePos == -100.5f)
            {
                cubeDir = true;
            }
        }
    }
}
