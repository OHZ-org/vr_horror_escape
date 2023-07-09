using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonYesEvent : MonoBehaviour
{
    private NoticeUI noticeUI;
    private KeyCollision keyCollision;

    void Start()
    {
        // keyCollision ������Ʈ ã�Ƽ� ������
        keyCollision = FindObjectOfType<KeyCollision>();

        // NoticeUI ������Ʈ�� ã�Ƽ� ������
        noticeUI = FindObjectOfType<NoticeUI>();

        // ��ư Ŭ�� �̺�Ʈ�� �Լ� �Ҵ�
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonYesClicked);
    }

    // '��' ��ư ������
    public void OnButtonYesClicked()
    {
        keyCollision.Check(); // �´� �������� üũ�ϴ� �Լ� ȣ��
        noticeUI.OnButtonYesClicked(); // UI ����
    }

    void Update()
    {
        
    }
}
