using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonNoEvent : MonoBehaviour
{
    private NoticeUI noticeUI;

    void Start()
    {
        // NoticeUI 컴포넌트를 찾아서 가져옴
        noticeUI = FindObjectOfType<NoticeUI>();

        // 버튼 클릭 이벤트에 함수 할당
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonNoClicked);
    }

    // '아니오' 버튼 눌렸을 때
    private void OnButtonNoClicked()
    {
        noticeUI.OnButtonNoClicked(); // '아니오' 버튼 눌리면 UI 종료함수 호출
    }

    void Update()
    {
        
    }
}
