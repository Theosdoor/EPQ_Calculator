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
        subtext.text = " ";
    }

    public void ClearText()
    {
        subtext.text = " ";
    }
}
