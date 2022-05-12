using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundLevelSelection : MonoBehaviour
{
    public AudioSource SoundBtnPlay;
    public AudioSource SoundBtn;
    public int numscene;
    public int numsceneAfter;
    // Start is called before the first frame update
    void Start()
    {
        SoundBtn.Stop();
        SoundBtnPlay.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SoundBtnClick1()
    {
        SoundBtn.Play();
    }
    public void SoundBtnPlayClick1()
    {
        SoundBtnPlay.Play();
    }

    public void OptionBackClick1()
    {
        SceneManager.LoadScene(numscene);
    }

    public void OptionPlayClick1()
    {
        SceneManager.LoadScene(numsceneAfter);
    }
}
