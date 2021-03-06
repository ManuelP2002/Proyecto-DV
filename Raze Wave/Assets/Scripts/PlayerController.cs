using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerController : MonoBehaviour
{
    public GenerateCurrency gemCurrency;
    public GeneratePotions potGen;
    

    public TextMeshProUGUI contadorGemas;
    public TextMeshProUGUI contadorVida;
    public TextMeshProUGUI contadorPociones;

    public float runSpeed = 7;
	public float rotSpeed = 250;
    public int contarDin = 0;
    public int contarPot = 0;
    public int health = 20;
    public int actHealth;
	public Animator animator;
    private GameObject atbot;
    private GameObject drone;
    private GameObject spider; 
	private float x, y;

    private void Start()
    {
        contadorVida.text = health + "/20";

        atbot = GameObject.FindGameObjectWithTag("atBot");
        spider = GameObject.FindGameObjectWithTag("spiderBot");
        drone = GameObject.FindGameObjectWithTag("droneBot");
    }
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * rotSpeed, 0);

        transform.Translate(0,0, y * Time.deltaTime * runSpeed);

        animator.SetFloat("Vx", x);
        animator.SetFloat("Vy",y);
    }

 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Gem"))
        {
            Destroy(other.gameObject);
            contarDin += 1;
            contadorGemas.text = contarDin.ToString();
            gemCurrency.gemCount -= 1;
        }

        if (other.gameObject.tag.Equals("Health"))
        {
            Destroy(other.gameObject);
            contarPot += 1;
            contadorPociones.text = contarPot.ToString();
            potGen.potCount -= 1;
        }
    }

     public void Descontar(int valor)
    {
        contarDin -= valor;

    }

     public void Heal()
    {
        if (contarPot > 0)
        { 
            if (health < 20)
            {
                health += 5;
                contadorVida.text = health + "/20";
                contarPot -= 1;
                contadorPociones.text = contarPot.ToString();
                if (health > 20)
                {
                    actHealth = 20;
                    contadorVida.text = health + "/20";
                }
            }
        }
     }

    
}