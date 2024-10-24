using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame.QuestSystem
{
    // ���� óġ ����Ʈ�� ������ �����ϴ� Ŭ����
    public class KillQuestCondition : IQuestCondition
    {
        private string enemyType;       // óġ�ؾ� �� ���� ����
        private int requiredKills;      // óġ�ؾ� �� �� ���� ��
        private int currentKills;       // óġ�� ���� ��

        // óġ ����Ʈ ���� �ʱ�ȭ ������
        public KillQuestCondition(string enemyType, int requiredKills)
        {
            this.enemyType = enemyType;
            this.requiredKills = requiredKills;
            this.currentKills = 0;
        }
        // ��ǥ óġ ���� �޼� �ߴ��� Ȯ��
        public bool IsMet() => currentKills >= requiredKills;
        // óġ ���� 0���� �ʱ�ȭ
        public void Initialize() => currentKills = 0;
        // ���� óġ ���൵�� �ۼ�Ʈ�� ��ȯ
        public float GetProgress() => (float)currentKills / requiredKills;
        // ����Ʈ ���� ������ ���ڿ��� ��ȯ
        public string GetDescription() => $"Defeat {requiredKills} {enemyType} {currentKills}/{requiredKills}";
        // �� óġ�� ȣ��Ǵ� �޼���
        public void EnemyKilled(string enemyType)
        {
            if(this.enemyType == enemyType)
            {
                currentKills++;
            }
        }

    }
}

