using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame.QuestSystem
{
    // �������� �����ϴ� ����Ʈ ������ ���� �ϴ� Ŭ����
    public class CollectionQuestCondition : IQuestCondition
    {
        private string itemId;          // �����ؾ� �� ������ ID
        private int requiredAmount;     // �����ؾ� �� ������ ����
        private int currentAmount;      // ������� ������ ������ ����

        // �����ڿ��� ������ ID�� �ʿ��� ������ ����
        public CollectionQuestCondition(string itemId, int requiredAmount)
        {
            this.itemId = itemId;
            this.requiredAmount = requiredAmount;
            this.currentAmount = 0;
        }
        // ����Ʈ ������ �����Ǿ����� ���� Ȯ��
        public bool IsMet() => currentAmount > requiredAmount;
        // ������ �ʱ�ȭ �Ͽ� ������ 0
        public void Initialize() => currentAmount = 0;
        // ���� ���� ��Ȳ�� 0���� 1������ ������ ��ȯ
        public float GetProgress() => (float)currentAmount / requiredAmount;
        // ����Ʈ ���� ������ ���ڿ��� ��ȯ
        public string GetDescription() => $"Defeat {requiredAmount} {itemId} {currentAmount}/{requiredAmount}";

        public void ItemCollected(string itemId)
        {
            if(this.itemId == itemId)
            {
                currentAmount++;
            }
        }
    }
}

