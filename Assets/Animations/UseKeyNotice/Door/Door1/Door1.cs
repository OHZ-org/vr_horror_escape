using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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

    // Update is called once per frame
    void Update()
    {
        if (!door.IsLocked() && !anim.GetBool("Open"))
        {
            anim.SetBool("Open", true);
            UnityEngine.Debug.Log("@@@@@@@Animation Play.");
        }
    }
}
