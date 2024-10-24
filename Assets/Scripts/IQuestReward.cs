using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame.QuestSystem
{
    // 퀘스트 보상을 정의하는 기본 인터페이스
    public interface IQuestReward
    {
        // 플레이어에게 보상을 지급하는 함수
        void Grant(GameObject player);
        // 보상에 대한 설명을 반환하는 함수
        string GetDescription();
    }
}

