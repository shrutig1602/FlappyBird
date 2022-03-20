using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public Text pauseBtnText;
    

    public void onPausedGame()
    {
        if (GameManager.gameIsPaused == false)
        {
            
            Time.timeScale = 0f;
            pauseBtnText.text = "Resume";
            GameManager.gameIsPaused = true;
        }
        else {
            Time.timeScale = 1f;
            pauseBtnText.text = "Pause";
            GameManager.gameIsPaused = false;
        }
    }


        
}
