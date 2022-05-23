using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{

    public Transform target;
    float dist;
    public float range;
    public Transform pivot;
    private bool CanFire = true;
    public GameObject shootingPoint;
    public float ReloadDelay = 0.5f;
    public float speedBullet = 60;
    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Enemy").transform;
        
    }

    private void Update()
    {
        dist = Vector3.Distance(target.position, transform.position);
        if (dist <= range && CanFire)
        {
            
            AmmoManager.SpawnAmmo(shootingPoint, speedBullet);

            CanFire = false;
            Invoke("EnableFire", ReloadDelay);
            pivot.LookAt(target);
        }

    }
    void EnableFire()
    {
        CanFire = true;
    }
}
