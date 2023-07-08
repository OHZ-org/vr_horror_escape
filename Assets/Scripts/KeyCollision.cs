using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// DoorLock, Key �浹 üũ
public class KeyCollision : MonoBehaviour
{

    // 1. �˸�â ������Ʈ ����
    NoticeUI _notice; 
    
    // Start is called before the first frame update
    void Start()
    {
        // 2. �˸�â script�� ���� �ִ� ��ü�� ã�Ƽ� ������Ʈ ����
        _notice = FindObjectOfType<NoticeUI>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ����� �浹�ϴ� ���� �˸�â ����
    public void OnCollisionEnter(Collision collision)
    {
        // ����� �浹
        if (collision.gameObject.tag == "Key") 
        {
            // 3. �˸�â �ҷ�����
            _notice.SUB("Use Key?");
        }
    }
}
