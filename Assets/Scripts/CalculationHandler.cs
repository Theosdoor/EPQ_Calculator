using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculationHandler : MonoBehaviour
{
    Dictionary<int, NumButton> numButtonDict = new Dictionary<int, NumButton>();

    private void Start()
    {
        LoadButtons();
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
}