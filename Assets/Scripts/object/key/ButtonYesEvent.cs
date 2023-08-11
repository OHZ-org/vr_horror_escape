using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonYesEvent : MonoBehaviour
{
    private NoticeUI noticeUI;
    KeyCollisionAll keyCollision;
    Button button;

    void Start()
    {
        // keyCollision ������Ʈ ã�Ƽ� ������
        keyCollision = FindObjectOfType<KeyCollisionAll>();

        // NoticeUI ������Ʈ�� ã�Ƽ� ������
        noticeUI = FindObjectOfType<NoticeUI>();

        // ��ư Ŭ�� �̺�Ʈ�� �Լ� �Ҵ�
        button = GetComponent<Button>();
        button.onClick.AddListener(ButtonYesClicked);
    }

    // '��' ��ư ������
    public void ButtonYesClicked()
    {
        Debug.Log("OkButton Clicked");
        keyCollision.Check("keyName zz tested String"); // �´� �������� üũ�ϴ� �Լ� ȣ��
        noticeUI.OnButtonYesClicked(); // UI ����
    }

    void Update()
    {
        
    }
}
