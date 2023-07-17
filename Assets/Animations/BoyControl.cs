using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    public float v = 0.0f;
    public float h = 0.0f;
    public float moveSpeed = 1.0f;
    public Transform PlayerTr;
    public Animator animator;

    public float moveSpd = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        PlayerTr = GetComponent<Transform>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        v = Input.GetAxis("Vertical");
        h = Input.GetAxis("Horizontal");

        Vector3 moveDirect = (Vector3.forward * v) + (Vector3.right * h);

        PlayerTr.Translate(moveDirect.normalized * Time.deltaTime * moveSpd, Space.Self);

        if (v != 0.0f)
        {
            animator.SetBool("isWalking", true);
        }
        
        else if (h != 0.1f)
        {
            animator.SetBool("IsWalk", true);
        }

        else
        {
            animator.SetBool("isWalking", false);
        }

    }
}