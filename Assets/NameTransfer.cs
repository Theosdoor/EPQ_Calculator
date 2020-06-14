using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class NameTransfer : MonoBehaviour
{
    public string inputString = "2";

    [SerializeField] float multiplier = 2f;

    public GameObject inputField;
    public GameObject textDisplay;

    private void Update()
    {
        StoreName();
    }

    public void StoreName()
    {
        inputString = inputField.GetComponent<Text>().text;
        float inputFloat = float.Parse(inputString);
        SendInput(inputFloat);
    }

    public void SendInput(float inputFloat)
    {
        SendMessage("StoreValue", inputFloat);
    }
}
