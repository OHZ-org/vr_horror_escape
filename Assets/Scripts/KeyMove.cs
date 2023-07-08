using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

// DoorLock, Key �浹�� �۵��ϴ��� Ȯ���ϱ� ���� ���� ��ũ��Ʈ. ���� ����
// ���踦 �������� DoorLock�� �浹�� �� ȿ���� �߻��ϴ��� Ȯ���Ѵ�.
public class KeyMove : MonoBehaviour
{
    private float _speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        // W -> ���谡 ������ �̵�
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }

        // S -> ���谡 �ڷ� �̵�
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * _speed * Time.deltaTime);
        }
    }
}
