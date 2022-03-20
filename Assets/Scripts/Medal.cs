using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Medal : MonoBehaviour
{
    //Reference
    public Sprite normalMedal;
    public Sprite bronzeMedal;
    public Sprite silverMedal;
    public Sprite goldMedal;


    Image img;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        int gameScore = GameManager.gameFinalScore;

        if (gameScore <= 2)
        {
            img.sprite = normalMedal;
        }
        else if (gameScore > 2 && gameScore <= 4)
        {
            img.sprite = bronzeMedal;
        }
        else if (gameScore > 4 && gameScore <= 6)
        {
            img.sprite = silverMedal;
        }
        else if(gameScore > 6) {
            img.sprite = goldMedal;
        }




    }





   
}
