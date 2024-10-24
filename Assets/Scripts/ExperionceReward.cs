using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame.QuestSystem
{
    // ����ġ ������ �����ϴ� Ŭ����
    public class ExperionceReward : IQuestReward
    {
        // �������� ������ ����ġ ��
        private int experienceAmount;
        // ����ġ ���� �ʱ�ȭ ������
        public ExperionceReward(int experienceAmount)
        {
            this.experienceAmount = experienceAmount;
        }
        public void Grant(GameObject player)
        {
            // TODO : ���� ����ġ ���� ���� ����
            Debug.Log($"Granted {experienceAmount} experience");
        }
        // ���� ������ ���ڿ��� ��ȯ
        public string GetDescription() => $"{experienceAmount}";
    }
}

