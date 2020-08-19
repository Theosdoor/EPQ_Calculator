using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainDisplay : MonoBehaviour
{
    TextMeshProUGUI displayText;

    void Start()
    {
        displayText = GetComponentInChildren<TextMeshProUGUI>();
        displayText.text = "";
    }

    public void SetText(string text)
    {
        displayText.text = text;
    }

    public void ClearText()
    {
        displayText.text = "";
    }

    public void DisplayError()
    {
        displayText.text = "ERROR";
    }

    public string GetText()
    {
        return displayText.text;
    }

    public int GetTextLength()
    {
        return displayText.text.Length;
    }

    public void AddToText(char caption)
    {
        displayText.text += caption;
    }
}
