using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemys : MonoBehaviour
{

    public Transform[] spawnPoints; 
    public GameObject enemy; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnear",5,10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawnear()
    {
        int i = Random.Range(0,3);
        Instantiate(enemy,spawnPoints[i].position,transform.rotation);
    }
}
