using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1 : MonoBehaviour
{
    KeyCollision door;
    Animator anim;
    bool isOpen = false;

    void Start()
    {
        door = FindObjectOfType<KeyCollision>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (door.IsLocked() == false && isOpen == false)
        {
            anim.SetBool("Open", true);
            isOpen = true;
        }
    }
}
