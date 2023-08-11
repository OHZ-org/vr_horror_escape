using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollisionAll : MonoBehaviour
{
    bool locked = true; // true�� ��� ����. false�� �� ����

    // 1. �˸�â ������Ʈ ����
    NoticeUI _notice;

    private GameObject collidingKey; // �浹�� �߻��� ������ ���� ����. �´� �������� �Ǵ��� �� ���
    AudioSource[] arrayAudio; // [0]: �� ������ �Ҹ�, [1]: ��� �Ҹ�

    public string doorName; // �� ����(�̸�)


    void Start()
    {
        // 2. �˸�â script�� ���� �ִ� ��ü�� ã�Ƽ� ������Ʈ ����
        _notice = FindObjectOfType<NoticeUI>();
        arrayAudio = GameObject.Find("DoorLock1").GetComponents<AudioSource>();

        doorName = gameObject.name; // ��(�����)�� ���� (1,2,3)
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
        Debug.Log("Check() ȣ��");

        if (collidingKey != null)
        {
            if (doorName == "DoorLock1")
            {
                // 1�� �����ġ == 1�� ������ ��� // tag�� �ƴ϶� object name�� ���ؾ� ��
                if (collidingKey.name == "Key1")
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

            else if (doorName == "DoorLock2")
            {
                // 2�� �����ġ == 2�� ������ ��� // tag�� �ƴ϶� object name�� ���ؾ� ��
                if (collidingKey.name == "Key2")
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

            else if (doorName == "DoorLock3")
            {
                // 3�� �����ġ == 3�� ������ ��� // tag�� �ƴ϶� object name�� ���ؾ� ��
                if (collidingKey.name == "Key3")
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
            Debug.Log(doorName + collidingKey.name + locked);
        }
    }

    public bool IsLocked()
    {
        return locked;
    }
}
