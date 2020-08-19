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
        buttonValue = int.Parse(buttonText.text);
        buttonChar = buttonText.text[0];
    }

    private void Start()
    {
        calcHandler = FindObjectOfType<CalculationHandler>();
    }

    public void OnTapped()
    {
        calcHandler.ButtonTapped(buttonChar);
    }

    public int GetButtonValue()
    {
        return buttonValue;
    }
}
