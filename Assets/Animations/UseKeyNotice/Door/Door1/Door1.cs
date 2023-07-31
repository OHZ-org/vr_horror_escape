using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class Door1 : MonoBehaviour
{

    KeyCollision door;
    Animator anim;

    void Start()
    {
         door = FindObjectOfType<KeyCollision>();
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
