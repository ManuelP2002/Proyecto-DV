using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateIceB : MonoBehaviour
{
    public GameObject iceBombCurrency;

    public int xPos;
    public int zPos;
    public float timer;
    public int iceBombCount;
    void Start()
    {
        timer = 20f;
    }

    void Update()
    {
        if (timer > 0f)
        {
            timer -= Time.deltaTime;

        }

        if (iceBombCount < 2 && timer <= 0f)
        {
            xPos = Random.Range(-15, -6);
            zPos = Random.Range(7, -7);
            Instantiate(iceBombCurrency, new Vector3(xPos, 1, zPos), Quaternion.identity);
            timer = 40f;
            iceBombCount += 1;
        }

    }
}
