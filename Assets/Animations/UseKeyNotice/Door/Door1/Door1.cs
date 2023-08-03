using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class Door1 : MonoBehaviour
{

    KeyCollisionAll door;
    Animator anim;

    void Start()
    {
         door = FindObjectOfType<KeyCollisionAll>();
         anim = GetComponent<Animator>();
    }

    void Update()
    {
        
        if (!door.IsLocked())
        {
             anim.SetBool("Open", true);
             UnityEngine.Debug.Log("@@@@@@Animation Play.");
             UnityEngine.Debug.Log(anim.GetBool("Open"));
        }
        
    }
}
