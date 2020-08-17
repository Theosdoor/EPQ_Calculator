using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EqualsButtonHandler : MonoBehaviour
{
    [SerializeField] Addition additionButton;
    [SerializeField] MainDisplayTextHandler mainDisplay;

    public void CompleteFunction()
    {
        if (additionButton.isAddition)
        {
            ProcessAddition();
        }
    }

    private void ProcessAddition()
    {
        float valueOne = mainDisplay.GetPreFunctionValue();
        float valueTwo = mainDisplay.GetPostFunctionValue();

        float result = valueOne + valueTwo;
        mainDisplay.ClearAllText();
        mainDisplay.UpdateDisplay(result.ToString());
    }
}
