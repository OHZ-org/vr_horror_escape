using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

// DoorLock, Key 충돌이 작동하는지 확인하기 위한 더미 스크립트. 삭제 예정
// 열쇠를 움직여서 DoorLock과 충돌할 때 효과가 발생하는지 확인한다.
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
        // W -> 열쇠가 앞으로 이동
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }

        // S -> 열쇠가 뒤로 이동
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * _speed * Time.deltaTime);
        }
    }
}
