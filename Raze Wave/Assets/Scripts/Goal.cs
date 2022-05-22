using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Goal : MonoBehaviour
{
    public EnemyManager eMger;
    public PlayerController pMger;
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("atBot"))
        {
            Destroy(collision.gameObject);
            pMger.actHealth = pMger.health - 8;
            pMger.contadorVida.text = pMger.actHealth + "/20";
        }
        if (collision.gameObject.tag.Equals("spiderBot"))
        {
            Destroy(collision.gameObject);
            pMger.actHealth = pMger.health - 5;
            pMger.contadorVida.text = pMger.actHealth + "/20";
        }
        if (collision.gameObject.tag.Equals("droneBot"))
        {
            Destroy(collision.gameObject);
            pMger.actHealth = pMger.health - 3;
            pMger.contadorVida.text = pMger.actHealth + "/20";
        }
    }

}
