using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float timer = 0;
    public PlayerController pyer;
    
    public TextMeshProUGUI textoTimerPro;

    public GameObject[] screens;

    public int numsceneAfter;

    void Start()
    {
        for (int i = 0; i < screens.Length; i++)
        {
            screens[i].SetActive(false);
        }
        screens[0].SetActive(false);
     
    }


    void Update()
    {
        timer -= Time.deltaTime;
        textoTimerPro.text = "" + timer.ToString("f1");

        if (timer <= 0)
        {
            screens[0].SetActive(true);
            Time.timeScale = 0f;
        }

        else if (pyer.health<=0)
        {
            screens[1].SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void OptionContinuarClick1()
    {
        SceneManager.LoadScene(numsceneAfter);
    }
}
