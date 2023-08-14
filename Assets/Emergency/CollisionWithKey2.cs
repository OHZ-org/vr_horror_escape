using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithKey2 : MonoBehaviour
{

    public int doorNum;
    private string keyNum;

    bool locked = true;

    AudioSource[] arrayAudio;


    void Start()
    {
        arrayAudio = GetComponents<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject key = collision.gameObject;
        keyNum = collision.gameObject.name;
        if (collision.gameObject.tag == "Key")
        {
            Check(doorNum, keyNum, key);
        }
    }

    void Check(int doorNum, string keyNum, GameObject key)
    {
        if (doorNum == 1)
        {
            if (keyNum == "Key1")
            {
                arrayAudio[0].Play();
                locked = false;
                Destroy(key);
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
                locked = false;
                Destroy(key);

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
                arrayAudio[0].Play();
                locked = false;
                Destroy(key);

            }
            else
            {
                arrayAudio[1].Play();

            }
        }

    }

    public bool Locked()
    {
        return locked;
    }

    void Update()
    {

    }
}
