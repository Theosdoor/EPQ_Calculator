using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainDisplayTextHandler : MonoBehaviour
{
    TextMeshProUGUI mainText;
    string previousNumberString;

    void Start()
    {
        mainText = GetComponent<TextMeshProUGUI>();
        ClearText();
    }

    public void UpdateNumberDisplay(int numberValue)
    {
        mainText.text = numberValue.ToString();
    }

    public void ClearText()
    {
        mainText.text = " ";
    }
}
