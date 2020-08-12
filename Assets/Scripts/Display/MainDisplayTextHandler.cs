using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainDisplayTextHandler : MonoBehaviour
{
    TextMeshProUGUI mainText;
    float newNumberValue;
    string previousNumberString = "";
    string functionString;
    bool inFunction = false;

    void Start()
    {
        mainText = GetComponent<TextMeshProUGUI>();
        ClearAllText();
    }

    public void UpdateDisplay(string numberString)
    {
        mainText.text = numberString;
    }

    public void ReceiveNumber(int numberValue)
    {
        if (!inFunction)
        {
            newNumberValue = float.Parse(previousNumberString + numberValue);
            string newNumberString = newNumberValue.ToString();
            UpdateDisplay(newNumberString);
            previousNumberString = newNumberString;
        }
        else
        {
            newNumberValue = float.Parse(previousNumberString + numberValue);
            string newNumberString = newNumberValue.ToString();
            string newFullString = functionString + newNumberString;
            UpdateDisplay(newFullString);
            previousNumberString = newNumberString;
        }
    }

    public void ShowAddition(float numberValue)
    {
        string numberString = numberValue.ToString();
        functionString = numberString + " + ";
        UpdateDisplay(functionString);
        previousNumberString = "";
        inFunction = true;
    }

    public float GetNumberValue()
    {
        return newNumberValue;
    }

    public void ClearAllText()
    {
        mainText.text = "";
        previousNumberString = "";
        inFunction = false;
    }
}
