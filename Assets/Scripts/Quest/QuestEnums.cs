using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame.QuestSystem
{
    // ����Ʈ�� ���� ���¸� ��Ÿ���� ������
    public enum QuestStatus
    {
        /// <summary>
        /// ���� ���� ����
        /// </summary>
        NotStarted,
        /// <summary>
        /// ���� ���� ���� ����
        /// </summary>
        inProgress,
        /// <summary>
        /// �Ϸ�� ����
        /// </summary>
        Completed,
        /// <summary>
        /// ������ ����
        /// </summary>
        Failed
    }

    // ����Ʈ ������ �����ϴ� ������
    public enum QuestType
    {
        Collection,             // �������� �����ϴ� ����Ʈ
        Kill,                   // ���͸� óġ�ϴ� ����Ʈ
        Dialog,                 // NPC�� ��ȭ�ϴ� ����Ʈ
        Exploration,            // Ư�� ������ Ž���ϴ� ����Ʈ
        Escort                  // NPC�� ��ȣ/ȣ�� �ϴ� ����Ʈ
    }
}

