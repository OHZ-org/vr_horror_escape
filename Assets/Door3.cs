using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class Door3 : MonoBehaviour
{

    CollisionWithKey3 door;
    Animator anim;
    public static bool opened=false;

    private bool isLock = true;

    public void SetBool(bool x)
    {
        isLock = x;
    }

    void Start()
    {
        door = GetComponentInChildren<CollisionWithKey3>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        if (!door.Locked())
        {
            anim.SetBool("Open", true);
            UnityEngine.Debug.Log("@@@@@@Animation Play.");
            UnityEngine.Debug.Log(anim.GetBool("Open"));
            opened = true;
        }

    }
}
