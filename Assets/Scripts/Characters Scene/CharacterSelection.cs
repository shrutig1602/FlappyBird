using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    private GameObject[] characterList;

    private int index;

    private void Start()
    {

        index = PlayerPrefs.GetInt("CharacterSelected");



        characterList = new GameObject[transform.childCount];


        //Fill the array with our models
        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }



        //We toggle off their renderer so we cant see them at starting
        foreach (GameObject go in characterList)
        {
            go.SetActive(false);
        }



        //We toggle on the selected index
        if (characterList[index])
        {
            characterList[index].SetActive(true);
        }


    }


    public void ToggleLeft()
    {
        //sound
        AudioManager.audiomanager.Play("changing");


        //Toggle off the current model
        characterList[index].SetActive(false);



        index--;
        if (index < 0)
        {
            index = characterList.Length - 1;
        }


        //Toggle on the new model
        characterList[index].SetActive(true);

    }




    public void ToggleRight()
    {
        //sound
        AudioManager.audiomanager.Play("changing");


        //Toggle off the current model
        characterList[index].SetActive(false);



        index++;
        if (index == characterList.Length)
        {
            index = 0;
        }


        //Toggle on the new model
        characterList[index].SetActive(true);

    }



    public void SelectButton()
    {
        AudioManager.audiomanager.Play("btnClick");
        AudioManager.audiomanager.Play("transition");
        PlayerPrefs.SetInt("CharacterSelected", index);
        SceneManager.LoadScene("Menu");
    }



}
