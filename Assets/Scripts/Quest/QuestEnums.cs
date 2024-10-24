using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame.QuestSystem
{
    // 퀘스트의 현재 상태를 나타내는 열거형
    public enum QuestStatus
    {
        /// <summary>
        /// 아직 시작 안함
        /// </summary>
        NotStarted,
        /// <summary>
        /// 현재 진행 중인 상태
        /// </summary>
        inProgress,
        /// <summary>
        /// 완료된 상태
        /// </summary>
        Completed,
        /// <summary>
        /// 실패한 상태
        /// </summary>
        Failed
    }

    // 퀘스트 유형을 구분하는 열거형
    public enum QuestType
    {
        Collection,             // 아이템을 수집하는 퀘스트
        Kill,                   // 몬스터를 처치하는 퀘스트
        Dialog,                 // NPC와 대화하는 퀘스트
        Exploration,            // 특정 지역을 탐험하는 퀘스트
        Escort                  // NPC를 보호/호위 하는 퀘스트
    }
}

