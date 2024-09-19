using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCallback : MonoBehaviour
{
    // Action ����
    private Action greetingAction;

    void Start()
    {
        // Action �Լ� �Ҵ�
        greetingAction = SayHello;
        PerformGreeting(greetingAction);
    }

    void SayHello()
    {
        Debug.Log("Hello, World");
    }

    void PerformGreeting(Action greetingFunc)
    {
        greetingFunc?.Invoke();
    }
}
