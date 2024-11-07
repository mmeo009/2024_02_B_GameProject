using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using MyGame.QuestSystem;
using UnityEngine.UI;
using UnityEditor.Search;
public class SimpleQuestProgressUI : MonoBehaviour
{
    [Header("Quest List")]
    [SerializeField] private Transform questListParent;     // ����Ʈ ����� ǥ�õ� �θ� Transform
    [SerializeField] private GameObject questPrefabs;       // ����Ʈ UI ������

    [Header("Progress Test")]
    [SerializeField] private Button KillEnemyButton;        // �� óġ �׽�Ʈ ��ư
    [SerializeField] private Button CollectItemButton;      // ������ ���� �׽�Ʈ ��ư

    private QuestManager questManager;

    void Start()
    {
        questManager = QuestManager.Instance;

        KillEnemyButton.onClick.AddListener(OnKillEnemy);
        CollectItemButton.onClick.AddListener(OnCollectItem);

        questManager.OnQuestStarted += UpdateQuestUI;
        questManager.OnQuestCompleted += UpdateQuestUI;
    }

    private void CreateQuestUI(Quest quest)
    {
        GameObject questObj = Instantiate(questPrefabs, questListParent);

        TextMeshProUGUI titleText = questObj.transform.Find("TitleText").GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI progressText = questObj.transform.Find("ProgressText").GetComponent <TextMeshProUGUI>();

        titleText.text = quest.Title;
        progressText.text = $"Progress: {quest.GetProgress():P0}";
    }

    // ����Ʈ ���� ����� UI ������Ʈ
    private void UpdateQuestUI(Quest quest)
    {
        RefreshQuestList();
    }

    // ����Ʈ ��� ���ΰ�ħ
    private void RefreshQuestList()
    {
        foreach (Transform child in questListParent)        // ���� UI ����
        {
            Destroy(child.gameObject);
        }

        foreach (var quest in questManager.GetActiveQuest())
        {
            CreateQuestUI(quest);
        }
    }

    // �� óġ ��ư �̺�Ʈ
    private void OnKillEnemy()
    {
        questManager.OnEnemyKilled("Rat");
        RefreshQuestList();
    }

    // ������ ���� ��ư �̺�Ʈ
    private void OnCollectItem()
    {
        questManager.OnItemCollected("Herb");
        RefreshQuestList();
    }
}
