using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundSelection : MonoBehaviour
{
    private GameObject[] backgroundList;

    private int index;

    private void Start()
    {

        index = PlayerPrefs.GetInt("BgSelected");



        backgroundList = new GameObject[transform.childCount];


        //Fill the array with our models
        for (int i = 0; i < transform.childCount; i++)
        {
            backgroundList[i] = transform.GetChild(i).gameObject;
        }



        //We toggle off their renderer so we cant see them at starting
        foreach (GameObject go in backgroundList)
        {
            go.SetActive(false);
        }



        //We toggle on the selected index
        if (backgroundList[index])
        {
            backgroundList[index].SetActive(true);
        }


    }


    public void ToggleLeft()
    {
        //sound
        AudioManager.audiomanager.Play("changing");


        //Toggle off the current model
        backgroundList[index].SetActive(false);



        index--;
        if (index < 0)
        {
            index = backgroundList.Length - 1;
        }


        //Toggle on the new model
        backgroundList[index].SetActive(true);

    }




    public void ToggleRight()
    {
        //sound
        AudioManager.audiomanager.Play("changing");


        //Toggle off the current model
        backgroundList[index].SetActive(false);



        index++;
        if (index == backgroundList.Length)
        {
            index = 0;
        }


        //Toggle on the new model
        backgroundList[index].SetActive(true);

    }



    public void SelectButton()
    {
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        PlayerPrefs.SetInt("BgSelected", index);
        SceneManager.LoadScene("Menu");
    }



}
