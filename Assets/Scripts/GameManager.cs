using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //references
    public GameObject gameOverCanvas;
    public GameObject canvasScore;
    public GameObject newText;
    public GameObject getReadyText;
    public GameObject pauseButton;

    public Player player;

    public Text scoreText;

    
    

    int score;
    public static int gameFinalScore;

    int higscore;
    

    //references
    public Text panelScore;
    public Text panelHighScore;


    //game states
    public static bool gameHasStarted;
    public static bool gameIsPaused;

    

    private void Start()
    {

        
        score = 0;
        panelScore.text = score.ToString();
        
        higscore = DBManger.score;
        //higscore = PlayerPrefs.GetInt("highscore");
        panelHighScore.text = higscore.ToString();

        gameHasStarted = false;
        gameIsPaused = false;
       
    }


    public void GameHasStarted()
    {
        gameHasStarted = true;
        getReadyText.SetActive(false);
        pauseButton.SetActive(true);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        
    }


    public void GameOver()
    {
        //Debug.Log("Game Over");
        AudioManager.audiomanager.Play("die");
        gameOverCanvas.SetActive(true);

        //before deactivating score object , let's assign score value to gameFinalScore so that we can use it in medal script
        gameFinalScore = score;
        DBManger.recentscore = gameFinalScore;

        canvasScore.SetActive(false);
        //player.gameObject.SetActive(false);
        pauseButton.SetActive(false);
        PlayerPrefs.SetInt("Finish",1);
        Pause();
    }

    


    public void IncreaseScore()
    {
        score++;

        scoreText.text = "Score : " + score.ToString();

        panelScore.text = score.ToString();

        if (score > higscore)
        {
            higscore = score;
            panelHighScore.text = higscore.ToString();
            DBManger.score = higscore;
            //PlayerPrefs.SetInt("highscore", higscore);
            newText.SetActive(true);
        }

    }


    public void onOkBtnPressed()
    {
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }


    public void onMenuBtnPressed()
    {
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

}
