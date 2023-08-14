using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

// DoorLock, Key �浹 üũ
public class KeyCollision1 : MonoBehaviour
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

    //����� �浹�ϴ� ���� �˸�â ����
    public void OnCollisionEnter(Collision collision)
    {
        // ����� �浹   // tag�� Key�� UI ���
        if (collision.gameObject.tag == "Key")
        {
            Vector3 collisionPosition = collision.contacts[0].point;
            // 3. �˸�â �ҷ�����
            _notice.SUB1("Use Key?", collisionPosition, 1, collision.gameObject.name);

            collidingKey = collision.gameObject;
        }
    }

    // UI���� '���� ���' ��ư�� ������ �� ȣ���� �Լ�
    // ���� ��� ��ư�� ������ �� �´� �������� üũ
    public void Check(int doorNum, string keyName)
    {
        if (collidingKey != null)
        {
            // 1�� �����ġ == 1�� ������ ��� // tag�� �ƴ϶� object name�� ���ؾ� ��
            if (keyName == "Key1")
            {
                locked = false; // �� ��� ����

                // �� ������ ���� �߰�
                
                arrayAudio[0].Play();
                UnityEngine.Debug.Log("�Ҹ�");


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

    public bool IsLocked()
    {
        return locked;
    }
}
