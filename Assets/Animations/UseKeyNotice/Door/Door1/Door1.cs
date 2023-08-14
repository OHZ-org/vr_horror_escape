using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class Door1 : MonoBehaviour
{

    CollisionWithKey1 door;
    Animator anim;

    private bool isLock = true;

    public void SetBool(bool x)
    {
        isLock = x;
    }

    void Start()
    {
        door = GetComponentInChildren<CollisionWithKey1>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
        if (!door.Locked())
        {
             anim.SetBool("Open", true);
             UnityEngine.Debug.Log("@@@@@@Animation Play.");
             UnityEngine.Debug.Log(anim.GetBool("Open"));
        }
        
    }
}
