using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberButton : MonoBehaviour
{
    public int buttonValue;

    // Start is called before the first frame update
    void Start()
    {
        string buttonText = GetComponentInChildren<TextMeshProUGUI>().text;
        buttonValue = int.Parse(buttonText);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
