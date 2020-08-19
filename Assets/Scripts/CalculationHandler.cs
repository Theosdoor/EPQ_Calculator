using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CalculationHandler : MonoBehaviour
{
    [SerializeField] MainDisplay mainDisplay;

    Dictionary<int, NumButton> numButtonDict = new Dictionary<int, NumButton>();

    bool errorDisplayed, displayValid = false;

    float currentVal;
    float storedVal;
    float result;
    char storedOperator;

    private void Start()
    {
        LoadButtons();
        ButtonTapped('c');
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
            mainDisplay.SetText(currentVal.ToString());
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
            case 'x':
                result = storedVal * currentVal;
                break;
            case '÷':
                if (currentVal != 0)
                {
                    result = storedVal / currentVal;
                }
                else
                {
                    errorDisplayed = true;
                    mainDisplay.DisplayError();
                }
                break;
            default:
                {
                    Debug.Log("Unknown " + activeOperator);
                    break;
                }
        }
        currentVal = result;
        UpdateMainDisplay();
    }

    public void ButtonTapped(char caption)
    {
        if (errorDisplayed)
        {
            ClearCalc();
        }
        if ((caption >= '0' && caption <= '9') || caption == '.')
        {
            if(mainDisplay.GetTextLength() < 15 || !displayValid)
            {
                if (!displayValid)
                {
                    mainDisplay.SetText(caption == '.' ? "0" : "");
                }
                else if(mainDisplay.GetText() == "0" && caption != '.')
                {
                    mainDisplay.SetText("");
                }
                mainDisplay.AddToText(caption);
                displayValid = true;
            }
        }
        else if(caption == 'c')
        {
            ClearCalc();
        }
        else if(displayValid || storedOperator == '=')
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