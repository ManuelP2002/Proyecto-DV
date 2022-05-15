using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ItemController : MonoBehaviour
{
    public TextMeshProUGUI healthBar;
    int health = 20;
    int actHealth;
    int potionHealing = 3;
    public GameObject potionBtn;
    public GameObject iceBtn;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.text = health + "/20";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UsePotion()
    {
        if (health < 20)
        {
            health += potionHealing;
        }
    }


}
