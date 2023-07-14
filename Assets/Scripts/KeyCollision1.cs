using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

// �˼� �̤�  Key1,2,3 ��� �ϴ°� ��Ծ ������� �ڵ� ��¥�� �����ؼ� �����ġ�� ���� �־����
// class �̸��̶� Check() �Լ� ���� Key name �� �ٸ��ϴ�.

// DoorLock, Key �浹 üũ
public class KeyCollision : MonoBehaviour
{
    bool locked = true; // true�� ��� ����. false�� �� ����

    // 1. �˸�â ������Ʈ ����
    NoticeUI _notice;

    private GameObject collidingKey; // �浹�� �߻��� ������ ���� ����. �´� �������� �Ǵ��� �� ���

    AudioSource openingDoor; // ������ �Ҹ�
    AudioSource closedDoor; // �����ִ� �� �Ҹ�
    
    void Start()
    {
        // 2. �˸�â script�� ���� �ִ� ��ü�� ã�Ƽ� ������Ʈ ����
        _notice = FindObjectOfType<NoticeUI>();

        openingDoor = gameObject.GetComponent<AudioSource>();
        closedDoor = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    // ����� �浹�ϴ� ���� �˸�â ����
    public void OnCollisionEnter(Collision collision)
    {
        // ����� �浹   // tag�� Key�� UI ���
        if (collision.gameObject.tag == "Key") 
        {
            // 3. �˸�â �ҷ�����
            _notice.SUB("Use Key?");

            collidingKey = collision.gameObject;
        }
    }

    // UI���� '���� ���' ��ư�� ������ �� ȣ���� �Լ�
    // ���� ��� ��ư�� ������ �� �´� �������� üũ
    public void Check()
    {
        if (collidingKey != null)
        {
            // 1�� �����ġ == 1�� ������ ��� // tag�� �ƴ϶� object name�� ���ؾ� ��
            if (collidingKey.name == "Key1")
            {
                locked = false; // �� ��� ����

                // �� ������ ���� �߰�
                openingDoor.Play();
            }
            else
            {
                locked = true; // �� ��� ���� ���� (��� �ɵ�)

                // �� ��� �Ҹ� (�ޱ׶�) �߰�
                closedDoor.Play();
            }
        }
    }
}
