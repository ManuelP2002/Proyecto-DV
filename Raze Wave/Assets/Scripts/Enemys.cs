using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class Enemys : MonoBehaviour
{

    int enemyHP = 50;

public NavMeshAgent agent; 
    // Start is called before the first frame update
    void Start()
    {
        agent.destination= GameObject.Find("Meta").transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyHP <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("bullet"))
        {
            enemyHP -= 10;
        }
    }
}
