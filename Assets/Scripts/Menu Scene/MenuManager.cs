using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void onStartBtnPressed()
    {
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        SceneManager.LoadScene("Game");
        
    }

    public void onBgBtnPressed()
    {
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        SceneManager.LoadScene("BackgroundSelection");

    }

    public void onScoreBtnPressed()
    {
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        SceneManager.LoadScene("HighScore");

    }

    public void onSoundBtnPressed()
    {
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        SceneManager.LoadScene("Sound");

    }

    public void onCharactersBtnPressed()
    {
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Characters");
    }
}
