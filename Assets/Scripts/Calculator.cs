using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    [SerializeField] List<int> numberList = new List<int>();

    public void StoreNumber(int numberValue)
    {
        numberList.Add(numberValue);
    }
}
