using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CalculationHandler : MonoBehaviour
{
    [SerializeField] MainDisplay mainDisplay;

    Dictionary<int, NumButton> numButtonDict = new Dictionary<int, NumButton>();

    float currentVal, storedVal;
    float result;
    char storedOperator;
    bool errorDisplayed, displayValid = false;
    

    private void Start()
    {
        LoadButtons();
        ClearCalc();
    }

    private void LoadButtons()
    {
        NumButton[] numButtons = FindObjectsOfType<NumButton>();
        foreach (NumButton button in numButtons)
        {
            int buttonValue = button.GetButtonValue();
            if (numButtonDict.ContainsKey(buttonValue))
            {
                Debug.LogWarning("Dictionary already contains a button value of " + buttonValue);
            }
            else
            {
                numButtonDict.Add(buttonValue, button);
            }
        }
    }

    public void ClearCalc()
    {
        mainDisplay.ClearText();
        currentVal = result = storedVal = 0;
        displayValid = errorDisplayed = false;
        storedOperator = ' ';
    }
 
    void UpdateMainDisplay()
    {
        if (!errorDisplayed)
        {
            mainDisplay.SetText(currentVal.ToString() + storedOperator);
        }
        displayValid = false;
    }

    void CalcResult(char activeOperator)
    {
        switch (activeOperator)
        {
            case '=':
                result = currentVal;
                break;
            case '+':
                result = storedVal + currentVal;
                break;
            case '-':
                result = storedVal - currentVal;
                break;
            case '×':
                result = storedVal * currentVal;
                break;
            case '÷':
                ProcessDivision();
                break;
            default:
                {
                    Debug.Log("Unknown operator: " + activeOperator);
                    break;
                }
        }
        currentVal = result;
        UpdateMainDisplay();
    }

    private void ProcessDivision()
    {
        if (currentVal != 0)
        {
            result = storedVal / currentVal;
        }
        else
        {
            errorDisplayed = true;
            mainDisplay.DisplayError();
        }
    }

    public void ButtonTapped(char caption)
    {
        if (errorDisplayed)
        {
            ClearCalc();
        }
        if ((caption >= '0' && caption <= '9') || caption == '.')
        {
            if (mainDisplay.GetTextLength() < 14 || !displayValid)
            {
                if (!displayValid)
                {
                    mainDisplay.SetText(caption == '.' ? "0" : "");
                }
                else if (mainDisplay.GetText() == "0" && caption != '.')
                {
                    mainDisplay.SetText("");
                }
                mainDisplay.AddToText(caption);
                displayValid = true;
            }
        }
        else if (displayValid || storedOperator == '=')
        { 
            currentVal = float.Parse(mainDisplay.GetText());
            displayValid = false;
            if(storedOperator != ' ')
            {
                CalcResult(storedOperator);
                storedOperator = ' ';
            }
            mainDisplay.AddToText(caption);
            storedOperator = caption;
            storedVal = currentVal;
            UpdateMainDisplay();
        }
    }
}