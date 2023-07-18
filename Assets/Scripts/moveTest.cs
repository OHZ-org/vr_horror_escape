using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 0.01f;  // 이동 속도를 조절할 변수

    private Rigidbody rigidbody;
    private Animator animator;
    private Camera mainCamera;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        mainCamera = Camera.main;
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0, v);
        movement.Normalize();  // 대각선 이동 시 이동 벡터를 정규화하여 일정한 속도로 이동하도록 함

        Vector3 cameraForward = Vector3.Scale(mainCamera.transform.forward, new Vector3(1, 0, 1)).normalized;
        Vector3 moveDirection = cameraForward * v + mainCamera.transform.right * h;

        rigidbody.MovePosition(transform.position + moveDirection * moveSpeed * Time.deltaTime);

        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(-moveDirection);  // 이동 방향을 향하도록 플레이어의 회전을 설정
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
