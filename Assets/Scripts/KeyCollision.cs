using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// DoorLock, Key 충돌 체크
public class KeyCollision : MonoBehaviour
{

    // 1. 알림창 컴포넌트 선언
    NoticeUI _notice; 
    
    // Start is called before the first frame update
    void Start()
    {
        // 2. 알림창 script를 갖고 있는 객체를 찾아서 컴포넌트 연결
        _notice = FindObjectOfType<NoticeUI>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 열쇠와 충돌하는 동안 알림창 띄우기
    public void OnCollisionEnter(Collision collision)
    {
        // 열쇠와 충돌
        if (collision.gameObject.tag == "Key") 
        {
            // 3. 알림창 불러오기
            _notice.SUB("Use Key?");
        }
    }
}
