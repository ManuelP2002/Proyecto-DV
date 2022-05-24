using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectar : MonoBehaviour
{
    GameObject focus;
 Turret tcRoot; 
 float timeNextBullet; 
void Start(){
    tcRoot=transform.parent.gameObject.GetComponent<Turret>(); 
}
       
   void OnTriggerStay(Collider other)
    { 
       if(other.gameObject.tag.Equals("Enemy"))
       { 
            if (focus == null)
            {
                focus = other.gameObject;
                tcRoot.cañon.transform.LookAt(other.transform);

            }
                
             
            
            if(Time.time>timeNextBullet)
            {
                Instantiate(tcRoot.bulletReference,tcRoot.bulletSpawn.position,tcRoot.bulletSpawn.rotation);
                timeNextBullet =Time.time+tcRoot.fireRate; 
            }
           
       }
   }

    private void OnTriggerExit(Collider other)
    {
        if (focus == other.gameObject)
        {
            focus = null;
        }
    }
}
