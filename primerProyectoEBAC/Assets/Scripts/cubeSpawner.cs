using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeSpawner : MonoBehaviour
{
    public GameObject prefabCube;
    public List<GameObject> cubeList;
    public float scaleFactor;
    public int cubeAmount = 0;
    // Start is called before the first frame update
    void Start()
    {
        cubeList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        cubeAmount++;
        GameObject tempGameObj = Instantiate<GameObject>(prefabCube);
        tempGameObj.name = "Cube Number " + cubeAmount;
        Color color = new Color(Random.value, Random.value, Random.value);
        tempGameObj.GetComponent<MeshRenderer>().material.color = color;
        tempGameObj.transform.position = Random.insideUnitSphere;

        cubeList.Add(tempGameObj);
        List<GameObject> objToDelete = new List<GameObject>();
        foreach(GameObject go in cubeList)
        {
            float scale = go.transform.localScale.x;
            scale *= scaleFactor;
            go.transform.localScale = Vector3.one * scale;

            if(scale < 0.1)
            {
                objToDelete.Add(go);
            }
        };

        foreach(GameObject go in objToDelete)
        {
            cubeList.Remove(go);
            Destroy(go);
        }
    }
}
