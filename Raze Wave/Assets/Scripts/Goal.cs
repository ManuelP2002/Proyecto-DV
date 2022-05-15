using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Goal : MonoBehaviour
{
    public ItemController health , actHealth;
    public EnemyController enemyDmg;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Destroy(collision.gameObject);
            health -= enemyDmg;
            actHealth += health;
        }
           
    }

}
