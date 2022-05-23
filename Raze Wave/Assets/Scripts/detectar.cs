using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectar : MonoBehaviour
{
 Turret tcRoot; 
 float timeNextBullet; 
void Start(){
    tcRoot=transform.parent.gameObject.GetComponent<Turret>(); 
}
       
   void OnTriggerStay(Collider obj){

       switch(obj.tag){

             case "enemy":
            tcRoot.toweHead.transform.LookAt(obj.transform);
            if(Time.time>timeNextBullet){
            Instantiate(tcRoot.bulletReference,tcRoot.bulletSpawn.position,tcRoot.bulletSpawn.rotation);
            timeNextBullet =Time.time+tcRoot.fireRate; 

            }
            break;
       }
   }
}
