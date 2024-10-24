using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame.QuestSystem
{
    // ����Ʈ ������ �����ϴ� �⺻ �������̽�
    public interface IQuestReward
    {
        // �÷��̾�� ������ �����ϴ� �Լ�
        void Grant(GameObject player);
        // ���� ���� ������ ��ȯ�ϴ� �Լ�
        string GetDescription();
    }
}

