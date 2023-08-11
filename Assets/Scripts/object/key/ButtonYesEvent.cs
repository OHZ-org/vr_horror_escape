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
        // keyCollision 컴포넌트 찾아서 가져옴
        keyCollision = FindObjectOfType<KeyCollisionAll>();

        // NoticeUI 컴포넌트를 찾아서 가져옴
        noticeUI = FindObjectOfType<NoticeUI>();

        // 버튼 클릭 이벤트에 함수 할당
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonYesClicked);
    }

    // '예' 버튼 눌리면
    public void OnButtonYesClicked()
    {
        Debug.Log("OkButton Clicked");
        keyCollision.Check(); // 맞는 열쇠인지 체크하는 함수 호출
        noticeUI.OnButtonYesClicked(); // UI 닫음
    }

    void Update()
    {
        
    }
}
