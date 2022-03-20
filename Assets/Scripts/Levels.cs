using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Levels : MonoBehaviour
{

    // public Text output;



    /*public void HandleDropDown(int val)
    {
        if (val == 0)
        {
            PipesMovementToLeft.speed = 6f;
            Spawner.maxTime = 1f;
            Spawner.maxY = 1f;
            Spawner.minY = -1f;


           // output.text = "Hello";
        }
        if (val == 1)
        {
            PipesMovementToLeft.speed = 4f;
            Spawner.maxTime = 0.9f;
            Spawner.maxY = 2f;
            Spawner.minY = -1.3f;

            //output.text = "Hello Good ";
        }
        if (val == 2)
        {
            PipesMovementToLeft.speed = 3f;
            Spawner.maxTime = 0.74f;
            Spawner.maxY = 3f;
            Spawner.minY = -1.5f;

            //output.text = "Hello Hello Good Morning";
        }
    }*/


    public Dropdown dropdown;

    private void Start()
    {
        dropdown.value = PlayerPrefs.GetInt("DropdownValue");

        dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); });
    }


    public void DropdownItemSelected(Dropdown dropdown)
    {
        switch (dropdown.value)
        {
            case 0:
                {
                    PlayerPrefs.SetInt("DropdownValue", 0);
                    PipesMovementToLeft.speed = 6f;
                    Spawner.maxTime = 1f;
                    Spawner.maxY = 1f;
                    Spawner.minY = -1f;
                    break;
                }
            case 1:
                {
                    PlayerPrefs.SetInt("DropdownValue", 1);
                    PipesMovementToLeft.speed = 4f;
                    Spawner.maxTime = 0.9f;
                    Spawner.maxY = 2f;
                    Spawner.minY = -1.3f;
                    break;
                }
            case 2:
                {
                    PlayerPrefs.SetInt("DropdownValue", 2);
                    PipesMovementToLeft.speed = 3f;
                    Spawner.maxTime = 0.74f;
                    Spawner.maxY = 3f;
                    Spawner.minY = -1.5f;
                    break;
                }
        }

    }

}
