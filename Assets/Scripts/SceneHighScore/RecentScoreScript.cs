using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RecentScoreScript : MonoBehaviour
{

    public Text highScoringText;
    public Text scoringText;




    private void Awake()
    {
        if (DBManger.username == null)
        {
            AudioManager.audiomanager.Play("transition");
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        scoringText.text= (DBManger.recentscore).ToString();
        highScoringText.text = (DBManger.score).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToLeaderBoard()
    {
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        SceneManager.LoadScene("HighScore");
    }

    public void GoToMenu()
    {
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        SceneManager.LoadScene("Menu");
    }


}
