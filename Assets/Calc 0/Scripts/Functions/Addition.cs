using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    public bool isAddition = false;

    MainDisplayTextHandler mainDisplay;

    private void Start()
    {
        mainDisplay = FindObjectOfType<MainDisplayTextHandler>();
    }

    public void SetAsAddition()
    {
        isAddition = true;
    }

    public void AddValues()
    {
        print(mainDisplay.GetPreFunctionValue());
        print(mainDisplay.GetPostFunctionValue());
    }
}
