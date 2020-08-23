using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumButton : MonoBehaviour
{
    int buttonValue;
    TextMeshProUGUI buttonText;
    char buttonChar;
    CalculationHandler calcHandler;

    private void Awake()
    {
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
        if (buttonText.text[0] <= 9 && buttonText.text[0] >= 0)
        {
            buttonValue = int.Parse(buttonText.text);
        }
        else
        {
            buttonValue = 0;
        }
        buttonChar = buttonText.text[0];
    }

    private void Start()
    {
        calcHandler = FindObjectOfType<CalculationHandler>();
    }

    public void OnTapped()
    {
        if(buttonChar == '.')
        {
            calcHandler.ButtonTapped(true, buttonText.text);
        }
        else
        {
            calcHandler.ButtonTapped(false, buttonText.text);
        }
    }

    public int GetButtonValue()
    {
        return buttonValue;
    }
}
