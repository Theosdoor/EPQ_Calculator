using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SubtextHandler : MonoBehaviour
{
    TextMeshProUGUI subtext;

    void Start()
    {
        subtext = GetComponent<TextMeshProUGUI>();
        ClearText();
    }

    public void ClearText()
    {
        subtext.text = " ";
    }
}
