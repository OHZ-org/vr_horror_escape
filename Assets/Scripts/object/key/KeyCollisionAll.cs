using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollisionAll : MonoBehaviour
{
    bool locked = true; // true�� ��� ����. false�� �� ����

    // 1. �˸�â ������Ʈ ����
    NoticeUI _notice;

    GameObject collidingKey; // �浹�� �߻��� ������ ���� ����. �´� �������� �Ǵ��� �� ���
    AudioSource[] arrayAudio; // [0]: �� ������ �Ҹ�, [1]: ��� �Ҹ�

    public string doorName; // �� ����(�̸�)
    string keyNumber;


    void Start()
    {
        // 2. �˸�â script�� ���� �ִ� ��ü�� ã�Ƽ� ������Ʈ ����
        _notice = FindObjectOfType<NoticeUI>();
        arrayAudio = GameObject.Find("DoorLock1").GetComponents<AudioSource>();

        //doorName = gameObject.name; // ��(�����)�� ���� (1,2,3)

        // string doorName�� private���� �ٲٰ�
        //if (gameObject.name == "DoorLock1")
        //{
        //    doorName = "DoorLock1";
        //}
        //else if (gameObject.name == "DoorLock2")
        //{
        //    doorName = "DoorLock2";
        //}
        //else if (gameObject.name == "DoorLock3")
        //{
        //    doorName = "DoorLock3";
        //} �̷��� �ϸ� �ɱ�...?

        Debug.Log(doorName);

    }

    // ����� �浹�ϴ� ���� �˸�â ����
    public void OnCollisionEnter(Collision collision)
    {
        // ����� �浹   // tag�� Key�� UI ���
        if (collision.gameObject.tag == "Key")
        {
            Vector3 collisionPosition = collision.contacts[0].point;
            
            collidingKey = collision.gameObject;
            keyNumber = collidingKey.name;

            // 3. �˸�â �ҷ�����
            _notice.SUB("Use Key?", collisionPosition, keyNumber);
        }
    }

    // UI���� '���� ���' ��ư�� ������ �� ȣ���� �Լ�
    // ���� ��� ��ư�� ������ �� �´� �������� üũ
    public void Check(int UINum)
    {
        Debug.Log("Check() ȣ��");

        
            if (UINum == 1)
            {
                Debug.Log("DoorLock1");
                // 1�� �����ġ == 1�� ������ ��� // tag�� �ƴ϶� object name�� ���ؾ� ��
                if (keyNumber == "Key1")
                {
                    locked = false; // �� ��� ����

                    // �� ������ ���� �߰�
                    arrayAudio[0].Play();
                }
                else
                {
                    locked = true; // �� ��� ���� ���� (��� �ɵ�)

                    // �� ��� �Ҹ� (�ޱ׶�) �߰�
                    arrayAudio[1].Play();
                }
            }

            else if (UINum == 2)
            {
                Debug.Log("DoorLock2");

                // 2�� �����ġ == 2�� ������ ��� // tag�� �ƴ϶� object name�� ���ؾ� ��
                if (keyNumber == "Key2")
                {
                    locked = false; // �� ��� ����

                    // �� ������ ���� �߰�
                    arrayAudio[0].Play();
                }
                else
                {
                    locked = true; // �� ��� ���� ���� (��� �ɵ�)

                    // �� ��� �Ҹ� (�ޱ׶�) �߰�
                    arrayAudio[1].Play();
                }
            }

            else if (UINum == 3)
            {
                Debug.Log("DoorLock3");

                // 3�� �����ġ == 3�� ������ ��� // tag�� �ƴ϶� object name�� ���ؾ� ��
                if (keyNumber == "Key3")
                {
                    locked = false; // �� ��� ����

                    // �� ������ ���� �߰�
                    arrayAudio[0].Play();
                }
                else
                {
                    locked = true; // �� ��� ���� ���� (��� �ɵ�)

                    // �� ��� �Ҹ� (�ޱ׶�) �߰�
                    arrayAudio[1].Play();
                }
            }
            Debug.Log(doorName + keyNumber + locked);
        
    }

    public bool IsLocked()
    {
        return locked;
    }
}
