using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AllClearButton : MonoBehaviour
{
    [SerializeField] MainDisplayTextHandler mainTextDisplay;
    [SerializeField] SubtextHandler subtextDisplay;

    public void ClearDisplay()
    {
        subtextDisplay.ClearText();
        mainTextDisplay.ClearAllText();
    }
}
