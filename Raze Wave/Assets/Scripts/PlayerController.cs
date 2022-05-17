using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PlayerController : MonoBehaviour
{
    public GenerateCurrency gemCurrency;
    public GeneratePotions potGen;
    public GenerateIceB ibGen;

    public TextMeshProUGUI contadorGemas;
    public TextMeshProUGUI contadorVida;
    public TextMeshProUGUI contadorPociones;
    public TextMeshProUGUI contadorIceBombs;

    public float runSpeed = 7;
	public float rotSpeed = 250;
    public int contarDin = 0;
    public int contarPot = 0;
    public int contarIB = 0; 
	public Animator animator;

	private float x, y;

    private void Start()
    {
        
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
         if(other.gameObject.tag.Equals("Ice"))
        {
            Destroy(other.gameObject);
            contarIB += 1;
            contadorIceBombs.text = contarIB.ToString();
            ibGen.iceBombCount -= 1;
        }
    }

     public void Descontar(int valor)
    {
        contarDin -= valor;

    }
}