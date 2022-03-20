using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Registration : MonoBehaviour
{
    public InputField nameField;
    public InputField emailField;
    public InputField passwordField;

    public Button submitButton;

    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();

        form.AddField("name", nameField.text);
        form.AddField("email", emailField.text);
        form.AddField("password", passwordField.text);

        WWW www = new WWW("http://localhost/FlappyBird/register.php", form);

        yield return www;

        if (www.text == "0")
        {
            Debug.Log("User created successfully");
            AudioManager.audiomanager.Play("btnClick");
            AudioManager.audiomanager.Play("transition");
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
        else
        {
            Debug.Log("Usercreation failed. Error #" + www.text);
        }
    }


    public void VerifyInput()
    {
        //If the condition is true , you can click on Submit button or else it will disable the submit button
        submitButton.interactable = (nameField.text.Length >= 8 && passwordField.text.Length >= 8);
    }


    public void GoToMainMenu()
    {
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        SceneManager.LoadScene("MainMenu");
    }

}


