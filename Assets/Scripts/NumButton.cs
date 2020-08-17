using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumButton : MonoBehaviour
{
    int buttonValue;
    TextMeshProUGUI buttonText;

    private void Awake()
    {
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
        buttonValue = int.Parse(buttonText.text);
    }

    public void OnTapped()
    {
        //print(buttonValue);

    }

    public int GetButtonValue()
    {
        return buttonValue;
    }
}
