using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public GameObject player;
    public Color hoverColor;
    private GameObject turret;
    private Renderer rend;
    private Color startColor;
    bool turret1Press;
    bool turret2Press;

    public GameObject turret1Prefab;
    public GameObject turret2Prefab;


    

    private void Awake()
    {
       
    }
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
      
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
           
           turret = (GameObject)Instantiate(turret, transform.position, transform.rotation);

            if (turret1Press)
            {
                player.GetComponent<PlayerController>().Descontar(8);
            }

             if (turret2Press)
             {
                    player.GetComponent<PlayerController>().Descontar(15);
             }
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
    public void OnTurret1Click(GameObject turretToBuild)
    {
        if (player.GetComponent<PlayerController>().contarDin >= 8)
        {
            turret1Press = true;
            turret = turretToBuild;
        }
    }
}
