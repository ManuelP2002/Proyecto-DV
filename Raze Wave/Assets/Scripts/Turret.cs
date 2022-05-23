using UnityEditor;
using UnityEngine;


public class Turret : MonoBehaviour
{
    public GameObject toweHead;
    public Transform bulletSpawn; 
     public GameObject cañon ; 
     public GameObject bulletReference; 
     public float fireRate; 
     
        public GameObject rangeAttackVisusal; 
    public float rangeAttack; 

    void Start(){

           rangeAttackVisusal.GetComponent<SphereCollider>().radius=rangeAttack; 
    }


    void Update()
    {
    }
}
