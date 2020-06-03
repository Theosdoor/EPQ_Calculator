using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class ButtonHandler : MonoBehaviour
{
    float inputFloat;

    public void SetText(string text)
    {
        Text txt = transform.Find("Text").GetComponent<Text>();
        txt.text = text;
    }

    public void MultiplyButtonPushed()
    {
        SendMessage("Multiply", inputFloat);
    }
}
