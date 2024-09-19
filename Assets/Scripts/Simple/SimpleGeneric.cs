using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleGeneric : MonoBehaviour
{
    private void Start()
    {
        PrintValue(42);
        // ������ Hello, Generics! �Դϴ�?
        PrintValue("������");
        PrintValue(3.14f);
    }
    private void PrintValue<T>(T value)
    {
        Debug.Log($"Value : {value}, Type : {typeof(T)}");
    }
}
