using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Linq;
using System;

[Serializable]
public class UserProperty
{
    //public string username { set; get; }
    public string username;
    //public string score { set; get; }
    public string score;
}


[Serializable]
public class ObjectProperty
{
    public UserProperty[] myusers;
}








public class GetScoreBoard : MonoBehaviour
{
    
    public Text[] LeaderBoardText;
    public string url;

    List<UserProperty> ListBoard = new List<UserProperty>();

    ObjectProperty s = new ObjectProperty();






    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetLeader());
    }

    IEnumerator GetLeader()
    {
        UnityWebRequest www = UnityWebRequest.Get(url);
        yield return www.SendWebRequest();


        if (www.isDone)
        {
            var result = www.downloadHandler.text;
            Debug.Log(result);

            if (result != "0")
            {
                var JsonArrayString = "{\"myusers\":" + result + "}";

                s = JsonUtility.FromJson<ObjectProperty>(JsonArrayString);
                Debug.Log(JsonArrayString);
                for (int i = 0; i < s.myusers.Length; i++)
                {
                    ListBoard.Add(new UserProperty { username = s.myusers[i].username, score = s.myusers[i].score });
                }


                ShowLeaderBoard();


            }
            else
            {
                Debug.Log("Error");
            }


        }



    }




    public void ShowLeaderBoard()
    {
        /*LeaderBoardText[0].text = ListBoard.ElementAt(0).username; 
        LeaderBoardText[1].text = ListBoard.ElementAt(0).score;

        LeaderBoardText[2].text = ListBoard.ElementAt(1).username;
        LeaderBoardText[3].text = ListBoard.ElementAt(1).score;

        LeaderBoardText[4].text = ListBoard.ElementAt(2).username;
        LeaderBoardText[5].text = ListBoard.ElementAt(2).score;

        LeaderBoardText[6].text = ListBoard.ElementAt(3).username;
        LeaderBoardText[7].text = ListBoard.ElementAt(3).score;

        LeaderBoardText[8].text = ListBoard.ElementAt(4).username;
        LeaderBoardText[9].text = ListBoard.ElementAt(4).score;*/

        LeaderBoardText[0].text = "1";
       LeaderBoardText[1].text = ListBoard.ElementAt(0).username;
        LeaderBoardText[2].text = ListBoard.ElementAt(0).score;

        LeaderBoardText[3].text = "2";
        LeaderBoardText[4].text = ListBoard.ElementAt(1).username;
        LeaderBoardText[5].text = ListBoard.ElementAt(1).score;

        LeaderBoardText[6].text = "3";
        LeaderBoardText[7].text = ListBoard.ElementAt(2).username;
        LeaderBoardText[8].text = ListBoard.ElementAt(2).score;

        LeaderBoardText[9].text = "4";
        LeaderBoardText[10].text = ListBoard.ElementAt(3).username;
        LeaderBoardText[11].text = ListBoard.ElementAt(3).score;

        LeaderBoardText[12].text = "5";
        LeaderBoardText[13].text = ListBoard.ElementAt(4).username;
        LeaderBoardText[14].text = ListBoard.ElementAt(4).score;

    }



    public void GoToRecentScores()
    {
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        SceneManager.LoadScene("RecentScores");
    }

    public void GoToMenu()
    {
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        SceneManager.LoadScene("Menu");
    }


}
