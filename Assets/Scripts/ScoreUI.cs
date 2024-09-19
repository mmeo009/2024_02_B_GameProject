using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    // Ȱ��ȭ �� �̺�Ʈ ���
    private void OnEnable()
    {
        EventSystem.OnScoreChanged += UpdateScore;
        EventSystem.OnGameOver += ShowGameOver;
    }
    // ��Ȱ��ȭ �� �̺�Ʈ ����
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
