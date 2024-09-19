using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    // 스코어 반환 Action 등록
    public static event Action<int> OnScoreChanged;
    // 게임 상태 Action 등록
    public static event Action OnGameOver;

    private int score = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score += 10;
            // 스코어 변동시 호출
            OnScoreChanged?.Invoke(score);
        }
        // 게임 오버시 호출
        if (score >= 100)
        {
            OnGameOver?.Invoke();
        }
    }
}
