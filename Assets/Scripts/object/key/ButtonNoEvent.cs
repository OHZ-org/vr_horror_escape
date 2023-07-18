using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonNoEvent : MonoBehaviour
{
    private NoticeUI noticeUI;

    void Start()
    {
        // NoticeUI ������Ʈ�� ã�Ƽ� ������
        noticeUI = FindObjectOfType<NoticeUI>();

        // ��ư Ŭ�� �̺�Ʈ�� �Լ� �Ҵ�
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonNoClicked);
    }

    // '�ƴϿ�' ��ư ������ ��
    private void OnButtonNoClicked()
    {
        noticeUI.OnButtonNoClicked(); // '�ƴϿ�' ��ư ������ UI �����Լ� ȣ��
    }

    void Update()
    {
        
    }
}
