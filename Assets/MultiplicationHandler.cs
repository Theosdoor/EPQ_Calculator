using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class MultiplicationHandler : MonoBehaviour
{
    float inputFloat;
    float storedInputFloat;
    float resultFloat;
    float multiplier = 2f;

    public GameObject textDisplay;

    public void StoreValue(float inputFloat)
    {
        
        //print("Received"); //todo multiply input on press (perhaps take the string for the box
                             //in this script when x pressed?)
    }

    public void MultiplyValues(float storedInputFloat) // initiates on press
    {
        print(storedInputFloat);
        for (int i = 0; i < 4; i++) // todo make cleaner, just covers 2-click bug right now
        {
            resultFloat = storedInputFloat * multiplier;
            print(resultFloat);
            string theResultString = resultFloat.ToString();
            textDisplay.GetComponent<Text>().text = theResultString;
        }
    }

}
