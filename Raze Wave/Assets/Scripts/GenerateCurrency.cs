using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCurrency : MonoBehaviour
{
    public GameObject gemCurrency;
    public int xPos;
    public int zPos;
    public int gemCount;
    void Start()
    {
        StartCoroutine(GemDrop());
    }

    IEnumerator GemDrop()
    {
        while (gemCount < 12)
        {
            xPos = Random.Range(-15, -6);
            zPos = Random.Range(7, -7);
            Instantiate(gemCurrency, new Vector3(xPos, 1, zPos), Quaternion.identity);
            yield return new WaitForSeconds(3.5f);
            gemCount += 1;
        }


    }
}
