using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject[] screensApp;
    public GameObject[] screensSettings;
    public AudioSource SoundBtnPlay;
    public AudioSource SoundBtn;
    public int numscene;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < screensApp.Length; i++)
        {
            screensApp[i].SetActive(false);
        }
        screensApp[0].SetActive(true);
        for (int i = 0; i < screensSettings.Length; i++)
        {
            screensSettings[i].SetActive(false);
        }
        screensSettings[0].SetActive(true);
        SoundBtn.Stop();
        SoundBtnPlay.Stop();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OptionPlayClick1()
    {
        screensApp[0].SetActive(false);
        SceneManager.LoadScene(numscene);
    }
    public void OptionSettingsClick1()
    {
        screensApp[0].SetActive(false);
        screensApp[1].SetActive(true);
    }
    public void OptionCreditsClick1()
    {
        screensApp[0].SetActive(false);
        screensApp[2].SetActive(true);
    }
    public void OptionCloseClick1()
    {
        Application.Quit();
    }
    public void OptionBackScreenSettingsClick1()
    {
        screensApp[1].SetActive(false);
        screensApp[0].SetActive(true);
    }
    public void OptionBackScreenCreditsClick1()
    {
        screensApp[2].SetActive(false);
        screensApp[0].SetActive(true);
    }
    public void OptionSettingsSoundClick1()
    {
        screensSettings[1].SetActive(false);
        screensSettings[2].SetActive(false);
        screensSettings[0].SetActive(true);
    }
    public void OptionSettingsGameClick1()
    {
        screensSettings[0].SetActive(false);
        screensSettings[2].SetActive(false);
        screensSettings[1].SetActive(true);
    }
    public void OptionSettingsPoliticClick1()
    {
        screensSettings[0].SetActive(false);
        screensSettings[1].SetActive(false);
        screensSettings[2].SetActive(true);
    }

    public void SoundBtnClick1()
    {
        SoundBtn.Play();
    }
    public void SoundBtnPlayClick1()
    {
        SoundBtnPlay.Play();
    }
}
