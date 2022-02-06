using System.Collections.Generic;
using UnityEngine;

public class Pool
{
    public List<GameObject> pool;
    private GameObject mainObject;

    //Pool settings
    private int poolSize;
    private bool initialState;

    public Pool(GameObject mainObject, int poolSize=20, bool initialState=false)
    {
        this.mainObject = mainObject;

        this.poolSize = poolSize;
        this.initialState = initialState;

        this.pool = generatePool();
    }

    public List<GameObject> generatePool()
    {
        List<GameObject> newPool = new List<GameObject>();
        GameObject newObject;

        for (int i = 0; i < poolSize; i++)
        {
            newObject = GameObject.Instantiate(mainObject, Vector3.zero, Quaternion.identity);
            newObject.name = "Pooled object " + i.ToString();
            newObject.SetActive(this.initialState);
        }

        return newPool;
    }


}
