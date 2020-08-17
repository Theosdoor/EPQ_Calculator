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

    float preFunctionValue;
    float postFunctionValue;

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
        newNumberValue = float.Parse(previousNumberString + numberValue);
        string newNumberString = newNumberValue.ToString();

        if (!inFunction)
        {
            UpdateDisplay(newNumberString);
            previousNumberString = newNumberString;
            preFunctionValue = newNumberValue;

        }
        else
        {
            string newFullString = functionString + newNumberString;
            UpdateDisplay(newFullString);
            previousNumberString = newNumberString;
            postFunctionValue = newNumberValue;
        }
    }

    public void ShowAddition()
    {
        string numberString = newNumberValue.ToString();
        functionString = numberString + " + ";
        UpdateDisplay(functionString);
        previousNumberString = "";
        inFunction = true;
    }

    public float GetPreFunctionValue()
    {
        return preFunctionValue;
    }

    public float GetPostFunctionValue()
    {
        return postFunctionValue;
    }

    public float GetNumberValue()
    {
        return newNumberValue;
    }

    public void ResetValues()
    {
        ClearAllText();
        preFunctionValue = 0;
        postFunctionValue = 0;
    }

    public void ClearAllText()
    {
        mainText.text = "";
        previousNumberString = "";
        inFunction = false;
    }
}
