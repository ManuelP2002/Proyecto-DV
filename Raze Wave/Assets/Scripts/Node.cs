using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public PlayerController player;
    public Color hoverColor;
    private GameObject turret;
    private Renderer rend;
    private Color startColor;
    bool turret1Press;
    bool turret2Press;
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

 

    void OnMouseDown()
    {
        if (turret1Press == true || turret2Press ==true)
        {
            if (turret != null)
            {
                Debug.Log("No es posible construir");
                return;
            }
            GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
           turret = (GameObject)Instantiate(turretToBuild, transform.position, transform.rotation);

        }
    }

     void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }
     void OnMouseExit()
    {
        rend.material.color = startColor;
    }
    public void OnTurret1Click()
    {
        if (player.contarDin >= 8)
        {
            turret1Press = true;
            player.contarDin -= 8;
            BuildManager.instance.turretToBuild = BuildManager.instance.turret1Prefab;
        }
    }
    public void OnTurret2Click()
    {
        if (player.contarDin >= 15)
        {   
            turret2Press = true;
            player.contarDin -= 15;
            BuildManager.instance.turretToBuild = BuildManager.instance.turret2Prefab;
        }
    }
}
