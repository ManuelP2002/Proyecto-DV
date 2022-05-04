using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePotions : MonoBehaviour
{
    public GameObject potCurrency;

    public int xPos;
    public int zPos;
    public float timer;
    public int potCount;
    void Start()
    {
        timer = 25f;
    }

    void Update()
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;

        }

        if (potCount < 2 && timer <= 0f)
        {
            xPos = Random.Range(-15, -6);
            zPos = Random.Range(7, -7);
            Instantiate(potCurrency, new Vector3(xPos, 1, zPos), Quaternion.identity);
            timer = 35f;
            potCount += 1;
        }

    }
}
