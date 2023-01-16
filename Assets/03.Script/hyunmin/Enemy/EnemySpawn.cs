using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject prefabSpawn;
    public float repeat;

    public void Start()
    {
        if(repeat > 0)
        {
            InvokeRepeating("SpawnPoint",0.0f, repeat);
        }
    }

    public GameObject SpawnObject()
    {
        if(prefabSpawn != null)
        {
            return Instantiate(prefabSpawn, transform.position, Quaternion.identity);
        }
        return null;
    }
}
