using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteButton : MonoBehaviour
{
    CalculationHandler calcHandler;
    MainDisplay mainDisplay;

    private void Start()
    {
        calcHandler = FindObjectOfType<CalculationHandler>();
        mainDisplay = FindObjectOfType<MainDisplay>();
    }

    public void OnTapped()
    {
        mainDisplay.DeleteLastCharacter();
    }
}
