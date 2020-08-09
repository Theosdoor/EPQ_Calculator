using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainDisplayTextHandler : MonoBehaviour
{
    TextMeshProUGUI mainText;
    string previousNumberString;
    bool hasReceivedNumber = false;

    void Start()
    {
        mainText = GetComponent<TextMeshProUGUI>();
        ClearText();
    }

    public void UpdateNumberDisplay(string numberString)
    {
        mainText.text = numberString;
    }

    public void ReceiveNumber(int numberValue)
    {
        if(hasReceivedNumber == false)
        {
            previousNumberString = " ";
            hasReceivedNumber = true;
        }
        string newNumberString = previousNumberString + numberValue.ToString();
        previousNumberString = newNumberString;
        UpdateNumberDisplay(newNumberString);
    }

    public void ClearText()
    {
        mainText.text = " ";
    }
}
