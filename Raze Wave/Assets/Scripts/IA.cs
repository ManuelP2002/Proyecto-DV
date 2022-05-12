using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class IA : MonoBehaviour
{

    public NavMeshAgent navMeshAgent; 
    public GameObject destination1; 
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.destination=destination1.transform.position; 
    }
}
