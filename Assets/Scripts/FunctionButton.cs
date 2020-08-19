using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FunctionButton : MonoBehaviour
{
    [SerializeField] FunctionType functionType;

    TextMeshProUGUI buttonText;
    CalculationHandler calcHandler;

    private void Awake()
    {
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
    }

    void Start()
    {
        calcHandler = FindObjectOfType<CalculationHandler>();
    }

    void Update()
    {
        
    }

    public void OnTapped()
    {
        calcHandler.ButtonTapped(buttonText.text[0]);
    }
}
