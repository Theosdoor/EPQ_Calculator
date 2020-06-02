using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class NameTransfer : MonoBehaviour
{
    public string theNumberString;

    [SerializeField] float multiplier = 2f;

    float theResultFloat;

    public GameObject inputField;
    public GameObject textDisplay;

    bool isValidInput = true;

    private void Update()
    {
        CheckValidInput();
    }

    private void CheckValidInput()
    {
        if (theNumberString is string) //todo wont work as "1" is string too
        {
            StoreName();
        }
        else
        {
            isValidInput = false;
        }
    }

    private void StoreName()
    {
        theNumberString = inputField.GetComponent<Text>().text;
    }

    public void MultiplyValues() //initiates on enter
    {
        if (isValidInput) //todo fix
        {
            for(int i = 0; i < 3; i++) // todo make cleaner, just covers  2-click bug right now
            {
                float theNumberFloat = float.Parse(theNumberString);
                string theResultString = theResultFloat.ToString();

                theResultFloat = theNumberFloat * multiplier;

                textDisplay.GetComponent<Text>().text = theResultString;
            }  
        }
    }
}
