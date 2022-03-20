using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    //public Text playerDisplay;
    //public Text scoreDisplay;


    private void Awake()
    {
        if (DBManger.username == null)
        {
            AudioManager.audiomanager.Play("transition");
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }

        /*playerDisplay.text = "Player : " + DBManger.username;
        scoreDisplay.text = "Score : " + DBManger.score;*/
    }


    public void CallSaveData()
    {
        StartCoroutine(SavePlayerData());
    }


    //This all will happen when we quit the play button
    IEnumerator SavePlayerData()
    {
        WWWForm form = new WWWForm();
        form.AddField("email", DBManger.useremail);
        form.AddField("score", DBManger.score);
        form.AddField("recentscore",DBManger.recentscore);
        WWW www = new WWW("http://localhost/FlappyBird/savedata.php", form);

        yield return www;

        if (www.text == "0")
        {
            Debug.Log("Game Saved");
        }
        else
        {
            Debug.Log("Save Failed : Error #" + www.text);
        }

        DBManger.LogOut();
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");

    }


    //This will happen when click on Earn Points
    /*public void IncreaseScore()
    {
        DBManger.score++;
        scoreDisplay.text = "Score : " + DBManger.score;
    }*/



}