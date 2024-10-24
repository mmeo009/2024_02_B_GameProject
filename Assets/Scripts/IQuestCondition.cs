using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame.QuestSystem
{
    // ����Ʈ ������ �����ϴ� �������̽�
    public interface IQuestCondition
    {
        // ������ �����Ǿ����� ���� ��ȯ
        bool IsMet();
        // ������ �ʱ�ȭ �ϴ� �޼���
        void Initialize();
        // ���� ������ ����
        float GetProgress();
        // ���� ���� ��ȯ �޼���
        string GetDescription();
    }
}

