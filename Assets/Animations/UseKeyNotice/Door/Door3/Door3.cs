using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door3 : MonoBehaviour
{

    KeyCollision3 door;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        door = FindObjectOfType<KeyCollision3>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (door.IsLocked() == false)
        {
            anim.SetBool("Open", true);
        }
    }
}
