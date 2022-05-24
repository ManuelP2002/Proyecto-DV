using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Goal : MonoBehaviour
{
    
    public PlayerController pMger;
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        if (pMger.health < 0)
        {
            pMger.health = 0;
            pMger.contadorVida.text = pMger.health + "/20";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Destroy(collision.gameObject);
            pMger.health -= 5;
            pMger.contadorVida.text = pMger.health + "/20";
        }
       
    }

}
