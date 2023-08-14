using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheck : MonoBehaviour
{
    public LayerMask Wall; // �� ���̾�
    public float raycastDistance = 1.0f; // ������ ����

    private void Update()
    {
        // �÷��̾��� ��ġ�� �������� ���̸� ��� �浹 �˻�
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, raycastDistance, Wall))
        {
            // ���� �浹�� ���, �÷��̾��� �������� ����
            transform.position = hit.point - transform.forward * 0.1f; // ���� �پ ����
        }
    }
}