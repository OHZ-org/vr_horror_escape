using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithKey : MonoBehaviour
{

    public int doorNum;
    private string keyNum;

    AudioSource[] arrayAudio;

    Animator anim;



    void Start()
    {
        arrayAudio = GetComponents<AudioSource>();
        anim.GetComponentInParent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        keyNum = collision.gameObject.name;
        if (collision.gameObject.tag == "Key")
        {
            Check(doorNum, keyNum);
        }
    }

    void Check(int doorNum, string keyNum)
    {
        if (doorNum == 1)
        {
            if (keyNum == "Key1")
            {
                arrayAudio[0].Play();
                anim.SetBool("Open", true);
            }
            else
            {
                arrayAudio[1].Play(); 
            }
        }

        else if (doorNum == 2)
        {
            if (keyNum == "Key2")
            {
                arrayAudio[0].Play();
                anim.SetBool("Open", true);
            }
            else
            {
                arrayAudio[1].Play();

            }
        }

        else if (doorNum == 3)
        {
            if (keyNum == "Key3")
            {
                anim.SetBool("Open", true);
                arrayAudio[0].Play();

            }
            else
            {
                arrayAudio[1].Play();

            }
        }

    }

    void Update()
    {
        
    }
}
