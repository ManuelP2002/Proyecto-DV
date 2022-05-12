using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerTutorial : MonoBehaviour
{
    public GameObject[] screensApp;
    public AudioSource SoundBtn;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < screensApp.Length; i++)
        {
            screensApp[i].SetActive(false);
        }
        screensApp[0].SetActive(true);
        SoundBtn.Stop();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void btnContinueClick1()
    {
        screensApp[0].SetActive(false);
        screensApp[1].SetActive(true);
    }
    public void btnContinueClick2()
    {
        screensApp[1].SetActive(false);
        screensApp[2].SetActive(true);
    }
    public void btnContinueClick3()
    {
        screensApp[2].SetActive(false);
        screensApp[3].SetActive(true);
    }
    public void btnContinueClick4()
    {
        screensApp[3].SetActive(false);
        screensApp[4].SetActive(true);
    }
    public void btnContinueClick5()
    {
        screensApp[0].SetActive(false);
        screensApp[1].SetActive(false);
        screensApp[2].SetActive(false);
        screensApp[3].SetActive(false);
        screensApp[4].SetActive(false);
    }
    public void SoundBtnClick1()
    {
        SoundBtn.Play();
    }

}
