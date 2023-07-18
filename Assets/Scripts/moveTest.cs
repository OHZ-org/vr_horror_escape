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
    public float moveSpeed = 0.01f;  // �̵� �ӵ��� ������ ����

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
        movement.Normalize();  // �밢�� �̵� �� �̵� ���͸� ����ȭ�Ͽ� ������ �ӵ��� �̵��ϵ��� ��

        Vector3 cameraForward = Vector3.Scale(mainCamera.transform.forward, new Vector3(1, 0, 1)).normalized;
        Vector3 moveDirection = cameraForward * v + mainCamera.transform.right * h;

        rigidbody.MovePosition(transform.position + moveDirection * moveSpeed * Time.deltaTime);

        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(-moveDirection);  // �̵� ������ ���ϵ��� �÷��̾��� ȸ���� ����
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }
}
