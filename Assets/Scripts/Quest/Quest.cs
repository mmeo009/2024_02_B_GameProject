using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace MyGame.QuestSystem
{
    public class Quest
    {
        // ����Ʈ ���� �ĺ���
        public string Id { get; set; }
        // ����Ʈ ����
        public string Title { get; set; }
        // ����Ʈ�� �� ����
        public string Description { get; set; }
        // ����Ʈ ����
        public QuestType Type { get; set; }
        // ����Ʈ ���� ����
        public QuestStatus Status { get; set; }
        // ����Ʈ �䱸 ����
        public int Level { get; set; }
        // ����Ʈ �Ϸ� ���� ���
        private List<IQuestCondition> conditions = new List<IQuestCondition>();
        // ����Ʈ ���� ���
        private List<IQuestReward> rewards = new List<IQuestReward>();
        // ���� ����Ʈ ID ���
        private List<string> prerequisiteQuestIds;

        // ����Ʈ �ʱ�ȭ ������
        public Quest(string id, string title, string description, QuestType type, int level)
        {
            Id = id;
            Title = title;
            Description = description;
            Type = type;
            Status = QuestStatus.NotStarted;
            Level = level;

            this.conditions = new List<IQuestCondition>();
            this.rewards = new List<IQuestReward>();
            this.prerequisiteQuestIds = new List<string>();
        }

        public List<IQuestCondition> GetConditions() { return conditions; }

        public void AddCondition(IQuestCondition condition) { conditions.Add(condition); }

        public void AddReward(IQuestReward reward) { rewards.Add(reward); }

        public void Start()
        {
            if(Status == QuestStatus.NotStarted)
            {
                Status  = QuestStatus.inProgress;
                foreach(var condition in conditions)
                {
                    condition.Initialize();
                }
            }
        }

        public bool ChackCompletion()
        {
            if(Status != QuestStatus.inProgress) return false;
            return conditions.All(c => c.IsMet());
        }

        public void Complete(GameObject player)
        {
            if (Status != QuestStatus.inProgress) return;
            if(!ChackCompletion()) return;

            foreach(var reward in rewards)
            {
                reward.Grant(player);
            }

            Status = QuestStatus.Completed;
        }

        public float GetProgress()
        {
            if(conditions.Count == 0) return 0.0f;
            return conditions.Average(c =>c.GetProgress());
        }

        public List<string> GetConditonDescriptions()
        {
            return conditions.Select(c => c.GetDescription()).ToList();
        }
        public List<string> GetRewardDescriptions()
        {
            return rewards.Select(r => r.GetDescription()).ToList();
        }
    }
}

