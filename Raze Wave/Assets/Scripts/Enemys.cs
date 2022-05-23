using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class Enemys : MonoBehaviour
{



public NavMeshAgent agent; 
    // Start is called before the first frame update
    void Start()
    {
        agent.destination= GameObject.Find("Meta").transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
