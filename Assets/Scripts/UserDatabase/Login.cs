using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public InputField emailField;
    public InputField passwordField;

    public Text errorText;

    public Button submitButton;

    public void CallLogin()
    {
        StartCoroutine(LoginPlayer());
    }

    IEnumerator LoginPlayer()
    {
        WWWForm form = new WWWForm();

        form.AddField("email", emailField.text);
        form.AddField("password", passwordField.text);

        WWW www = new WWW("http://localhost/FlappyBird/login.php", form);

        yield return www;

        if (www.text[0] == '0')
        {
            DBManger.username = www.text.Split('\t')[2];
            DBManger.useremail = emailField.text;
            DBManger.score = int.Parse(www.text.Split('\t')[1]);
            DBManger.recentscore = int.Parse(www.text.Split('\t')[3]);
            AudioManager.audiomanager.Play("btnClick");
            AudioManager.audiomanager.Play("transition");
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
        else
        {
            Debug.Log("User login failed.Error #" + www.text);
            errorText.text = "* " + www.text;
        }


    }


    public void VerifyInput()
    {
        //If the condition is true , you can click on Submit button or else it will disable the submit button
        submitButton.interactable = ( passwordField.text.Length >= 8);
    }




    public void GoToMainMenu()
    {
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        SceneManager.LoadScene("MainMenu");
    }
    


}

