using TMPro;
using UnityEngine;

public class FunctionButton : MonoBehaviour
{
    TextMeshProUGUI buttonText;
    char buttonChar;

    CalculationHandler calcHandler;
    FunctionType functionType;

    private void Awake()
    {
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
        buttonChar = buttonText.text[0];
    }

    void Start()
    {
        calcHandler = FindObjectOfType<CalculationHandler>();
        SetFunctionType();
    }

    private void SetFunctionType()
    {
        switch (buttonChar)
        {
            case '+':
                functionType = FunctionType.Add;
                break;
            case '-':
                functionType = FunctionType.Subtract;
                break;
            case '×':
                functionType = FunctionType.Multiply;
                break;
            case '÷':
                functionType = FunctionType.Divide;
                break;
            case '=':
                functionType = FunctionType.Equals;
                break;
            default:
                //Debug.Log("Unknown function type: " + buttonChar);
                break;
        }
    }

    public void OnTapped()
    {
        calcHandler.ButtonTapped(true, buttonText.text);
    }
}
