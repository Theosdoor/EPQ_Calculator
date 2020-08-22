using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumButton : MonoBehaviour
{
    [SerializeField] bool isNumber;

    int buttonValue;
    TextMeshProUGUI buttonText;
    char buttonChar;
    CalculationHandler calcHandler;

    private void Awake()
    {
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
        if (isNumber)
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
        calcHandler.ButtonTapped(buttonChar);
    }

    public int GetButtonValue()
    {
        return buttonValue;
    }
}
