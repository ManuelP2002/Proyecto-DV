using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCurrency : MonoBehaviour
{
    public GameObject gemCurrency;

    public int xPos;
    public int zPos;
    public float timer;
    public int gemCount;
    void Start()
    {
        timer = 3f;
    }

    void Update()
    {
        if (timer > 0f)
        {
            timer = timer - Time.deltaTime;

        }

         if (gemCount < 12 && timer <=0f)
        {
                xPos = Random.Range(-15, -6);
                zPos = Random.Range(7, -7);
                Instantiate(gemCurrency, new Vector3(xPos, 1, zPos), Quaternion.identity);
                timer = 3f;
                gemCount += 1;
        }
      
    }
}
