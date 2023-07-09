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

    public float v = 0.0f;
    public float h = 0.0f;
    public float moveSpeed = 0.00001f;

    public Transform PlayerTr;
    public Animator animator;
    public Rigidbody rigidbody;
  

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        PlayerTr = GetComponent<Transform>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        animator.SetFloat("v", v);
       PlayerTr.Translate(new Vector3(h,0,v) * moveSpeed * Time.deltaTime);
        
        if(v!=0.0f)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        
    }

}