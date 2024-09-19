using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCallback : MonoBehaviour
{
    // Action 선언
    private Action greetingAction;

    void Start()
    {
        // Action 함수 할당
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
