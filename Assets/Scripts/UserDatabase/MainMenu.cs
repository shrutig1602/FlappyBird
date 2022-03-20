using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text playerDisplay;
    public Button registerButton;
    public Button loginButton;
    public Button playButton;

   

    private void Start()
    {
        if (DBManger.LoggedIn)
        {
            playerDisplay.text = "Player Name :  " + DBManger.username;
        }
        registerButton.interactable = !DBManger.LoggedIn;
        loginButton.interactable = !DBManger.LoggedIn;

        playButton.interactable = DBManger.LoggedIn;
    }
    
    public void GoToRegister()
    {
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        SceneManager.LoadScene("registermenu");
       
    }

    public void GoToLogin()
    {
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        SceneManager.LoadScene("loginmenu");
        
    }

    public void GoToGame()
    {
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        SceneManager.LoadScene("Menu");
       
    }


}