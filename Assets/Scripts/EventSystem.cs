using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    // ���ھ� ��ȯ Action ���
    public static event Action<int> OnScoreChanged;
    // ���� ���� Action ���
    public static event Action OnGameOver;

    private int score = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score += 10;
            // ���ھ� ������ ȣ��
            OnScoreChanged?.Invoke(score);
        }
        // ���� ������ ȣ��
        if (score >= 100)
        {
            OnGameOver?.Invoke();
        }
    }
}
