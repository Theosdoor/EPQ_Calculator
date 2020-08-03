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
        GetComponentInChildren<TextMeshProUGUI>().text = buttonValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SendValueToDisplay()
    {
        FindObjectOfType<MainDisplayTextHandler>().UpdateNumberDisplay(buttonValue);
    }
}
