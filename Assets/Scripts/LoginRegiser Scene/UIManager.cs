using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    //screen object variables
    public GameObject loginUI;
    public GameObject registerUI;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            Debug.Log("Instance Already exist, destroying object");
            Destroy(this);
        }
    }



    //To change Login To Register
    public void LoginScreen() //backBtn
    {
        loginUI.SetActive(true);
        registerUI.SetActive(false);
    }




    //To change Register back to login
    public void RegisterScreen() //RegisterBtn
    {
        loginUI.SetActive(false);
        registerUI.SetActive(true);
    }







}
