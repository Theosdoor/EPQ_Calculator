using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[DisallowMultipleComponent]
public class ButtonHandler : MonoBehaviour
{
    [SerializeField] int numberInput;

    private void Start()
    {
        string stringInput = gameObject.name;
        numberInput = int.Parse(stringInput);
        GetInput();
    }

    public int GetInput()
    {
        numberInput = numberInput + 1;
        return numberInput;
    }











    //ignore below for now

    private void Update()
    {
        ProcessInput();
    }

    private void ProcessInput ()
    {
        if (Input.GetKey(KeyCode.Plus))
        {
            print("hello");
        }
    }
}
