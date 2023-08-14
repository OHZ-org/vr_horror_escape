using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheck : MonoBehaviour
{
    public LayerMask Wall; // 벽 레이어
    public float raycastDistance = 1.0f; // 레이의 길이

    private void Update()
    {
        // 플레이어의 위치와 방향으로 레이를 쏘아 충돌 검사
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, raycastDistance, Wall))
        {
            // 벽과 충돌한 경우, 플레이어의 움직임을 막음
            transform.position = hit.point - transform.forward * 0.1f; // 벽에 붙어서 멈춤
        }
    }
}