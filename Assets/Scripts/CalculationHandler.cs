using System;
using UnityEngine;

public class CalculationHandler : MonoBehaviour
{
    [SerializeField] MainDisplay mainDisplay;

    float currentVal, storedVal;
    float result;
    string storedOperator;
    bool errorDisplayed, displayValid, specialAction = false; // i.e is display valid to do operation
    

    private void Start()
    {
        ClearCalc();
    }

    public void ClearCalc()
    {
        mainDisplay.ClearText();
        currentVal = result = storedVal = 0;
        displayValid = errorDisplayed = specialAction = false;
        storedOperator = "";
    }

    public void DeleteLastInput()
    {
        mainDisplay.DeleteLastCharacter();
    }

    void UpdateMainDisplay()
    {
        if (!errorDisplayed)
        {
            if (storedOperator == "=")
            {
                mainDisplay.SetText(currentVal.ToString());
            }
            else
            {
                mainDisplay.SetText(currentVal.ToString() + storedOperator);
            }
        }
        displayValid = false;
    }

    void CalcResult(string activeOperator)
    {
        switch (activeOperator)
        {
            case "=":
                result = currentVal;
                break;
            case "+":
                result = storedVal + currentVal;
                break;
            case "-":
                result = storedVal - currentVal;
                break;
            case "×":
                result = storedVal * currentVal;
                break;
            case "÷":
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

    public void ButtonTapped(bool isFunction, string caption)
    {
        if (errorDisplayed)
        {
            ClearCalc();
        }
        if ((!isFunction && int.Parse(caption) >= 0 && int.Parse(caption) <= 9) || caption == ".")
        {
            if (mainDisplay.GetTextLength() < 14 || !displayValid)
            {
                if (!displayValid)
                {
                    mainDisplay.SetText(caption == "." ? "0" : ""); // if there is number in front of '.' it becomes 6.7 etc. if there isn't then 0 is assumed as that number in front of '.'
                }
                else if (mainDisplay.GetText() == "0" && caption != ".")
                {
                    mainDisplay.SetText("");
                }
                mainDisplay.AddToText(caption);
                displayValid = true;
            }
        }
        else if (caption == "sin")
        {
            FindSineOfInput();
            specialAction = true;
        }
        else if (caption == "cos")
        {
            FindCosineOfInput();
            specialAction = true;
        }
        else if (caption == "tan")
        {
            FindTanOfInput();
            specialAction = true;
        }
        else if (caption == "!")
        {
            FindFactorialOfInput();
            specialAction = true;
        }
        else if (caption == "√")
        {
            FindSqRootOfInput();
            specialAction = true;
        }
        else if (caption == "x^2")
        {
            FindSquareOfInput();
            specialAction = true;
        }
        else if (displayValid || storedOperator == "=" || specialAction)
        {
            currentVal = float.Parse(mainDisplay.GetText());
            displayValid = false;
            if (storedOperator != "")
            {
                CalcResult(storedOperator);
                storedOperator = "";
            }
            mainDisplay.AddToText(caption);
            storedOperator = caption;
            storedVal = currentVal;
            UpdateMainDisplay();
            specialAction = false;
        }
    }


    private void FindSineOfInput()
    {
        float input = float.Parse(mainDisplay.GetText()); // get input from display
        currentVal = Mathf.Sin(input * Mathf.Deg2Rad); // calculate sine of input by converting to radians
        currentVal = (float)Math.Round(currentVal,6); // round to 5dp to avoid rounding errors caused by Deg2Rad
        UpdateMainDisplay();
    }

    private void FindCosineOfInput()
    {
        float input = float.Parse(mainDisplay.GetText());
        currentVal = Mathf.Cos(input * Mathf.Deg2Rad);
        currentVal = (float)Math.Round(currentVal, 6); // round to 5dp to avoid rounding errors
        UpdateMainDisplay();
    }

    private void FindTanOfInput()
    {
        float input = float.Parse(mainDisplay.GetText());
        if ((input / 90) % 2 == 1) // if input is odd multiple of 90 degrees 
        {
            errorDisplayed = true;
            mainDisplay.DisplayError();
        }
        else
        {
            currentVal = Mathf.Tan(input * Mathf.Deg2Rad);
            currentVal = (float)Math.Round(currentVal, 6); // round to 5dp to avoid rounding errors
            UpdateMainDisplay();
        }
    }

    private void FindFactorialOfInput()
    {
        float input = float.Parse(mainDisplay.GetText());
        int fact = 1;
        for (int i = 1; i <= input; i++)
        {
            fact *= i;
        }
        currentVal = fact;
        UpdateMainDisplay();
    }

    private void FindSqRootOfInput()
    {
        float input = float.Parse(mainDisplay.GetText());
        currentVal = Mathf.Sqrt(input);
        UpdateMainDisplay();
    }

    private void FindSquareOfInput()
    {
        float input = float.Parse(mainDisplay.GetText());
        currentVal = Mathf.Pow(input, 2);
        UpdateMainDisplay();
    }
}