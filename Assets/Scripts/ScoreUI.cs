using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    // 활성화 시 이벤트 등록
    private void OnEnable()
    {
        EventSystem.OnScoreChanged += UpdateScore;
        EventSystem.OnGameOver += ShowGameOver;
    }
    // 비활성화 시 이벤트 해제
    private void OnDisable()
    {
        EventSystem.OnScoreChanged -= UpdateScore;
        EventSystem.OnGameOver -= ShowGameOver;
    }

    private void UpdateScore(int newScore)
    {
        Debug.Log($"Socre Update : {newScore}");
    }

    private void ShowGameOver()
    {
        Debug.Log("GameOver!");
    }
}
