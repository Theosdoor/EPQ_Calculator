using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    MainDisplayTextHandler mainDisplay;

    private void Start()
    {
        mainDisplay = FindObjectOfType<MainDisplayTextHandler>();
    }

    public void AddValues()
    {
        float firstNumberValue = mainDisplay.GetNumberValue();

        mainDisplay.ShowAddition(firstNumberValue); // could use update display method

    }
}
