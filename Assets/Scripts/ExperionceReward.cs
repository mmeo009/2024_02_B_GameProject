using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame.QuestSystem
{
    // 경험치 보상을 구현하는 클래스
    public class ExperionceReward : IQuestReward
    {
        // 보상으로 지급할 경험치 량
        private int experienceAmount;
        // 경험치 보상 초기화 생성자
        public ExperionceReward(int experienceAmount)
        {
            this.experienceAmount = experienceAmount;
        }
        public void Grant(GameObject player)
        {
            // TODO : 실제 경험치 지급 로직 구현
            Debug.Log($"Granted {experienceAmount} experience");
        }
        // 보상 내용을 문자열로 반환
        public string GetDescription() => $"{experienceAmount}";
    }
}

