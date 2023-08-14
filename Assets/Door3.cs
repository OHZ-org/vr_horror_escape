using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class Door3 : MonoBehaviour
{

    KeyCollisionAll door;
    Animator anim;

    private bool isLock = true;

    public void SetBool(bool x)
    {
        isLock = x;
    }

    void Start()
    {
        door = FindObjectOfType<KeyCollisionAll>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        if (!isLock)
        {
            anim.SetBool("Open", true);
            UnityEngine.Debug.Log("@@@@@@Animation Play.");
            UnityEngine.Debug.Log(anim.GetBool("Open"));
        }

    }
}
