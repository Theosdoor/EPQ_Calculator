using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearButton : MonoBehaviour
{
    CalculationHandler calcHandler;


    private void Start()
    {
        calcHandler = FindObjectOfType<CalculationHandler>();
    }

    public void OnTapped()
    {
        calcHandler.ClearCalc();
    }
}
