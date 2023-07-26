using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

// DoorLock, Key �浹 üũ
public class KeyCollision3 : MonoBehaviour
{
    bool locked = true; // true�� ��� ����. false�� �� ����

    // 1. �˸�â ������Ʈ ����
    NoticeUI _notice;

    private GameObject collidingKey; // �浹�� �߻��� ������ ���� ����. �´� �������� �Ǵ��� �� ���

    //AudioSource openingDoor; // ������ �Ҹ�
    //AudioSource closedDoor; // �����ִ� �� �Ҹ�

    AudioSource[] arrayAudio;


    void Start()
    {
        // 2. �˸�â script�� ���� �ִ� ��ü�� ã�Ƽ� ������Ʈ ����
        _notice = FindObjectOfType<NoticeUI>();

        //openingDoor = gameObject.GetComponent<AudioSource>();
        //closedDoor = gameObject.GetComponent<AudioSource>();

        arrayAudio = GameObject.Find("DoorLock1").GetComponents<AudioSource>();

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
            Vector3 collisionPosition = collision.contacts[0].point;
            // 3. �˸�â �ҷ�����
            _notice.SUB("Use Key?", collisionPosition);

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
                //openingDoor.Play();
                arrayAudio[0].Play();
            }
            else
            {
                locked = true; // �� ��� ���� ���� (��� �ɵ�)

                // �� ��� �Ҹ� (�ޱ׶�) �߰�
                //closedDoor.Play();
                arrayAudio[1].Play();
            }
        }
    }
}
