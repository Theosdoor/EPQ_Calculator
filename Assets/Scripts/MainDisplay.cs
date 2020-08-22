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
        ClearText();
    }

    public void SetText(string txt)
    {
        displayText.text = txt;
    }

    public void ClearText()
    {
        displayText.text = "0";
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

    public void DeleteLastCharacter()
    {
        displayText.text.Remove(displayText.text.Length, -1);
    }
}
