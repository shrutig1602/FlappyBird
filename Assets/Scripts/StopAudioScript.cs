using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StopAudioScript : MonoBehaviour
{
    private static StopAudioScript backgroundMusic;

    private AudioSource audioSource;

    private bool SongLoaded;

    private string lastScene;
    private string currentScene;


    int check;



    void Awake()
    {

        check = PlayerPrefs.GetInt("Finish");

        /*if (backgroundMusic == null && SceneManager.GetActiveScene().name != "Game")
        {
            backgroundMusic = this;
            DontDestroyOnLoad(transform.gameObject);
        }
        else if(backgroundMusic != null)
        {
            Destroy(transform.gameObject);
        }*/

        if (check == 1)
        {
            Destroy(transform.gameObject);
        }


    }
}
