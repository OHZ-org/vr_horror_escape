using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVButton : MonoBehaviour
{
    private bool pushed = false;
    AudioSource sound;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // ���� ���¿��� �浹
            if (!pushed)
            {
                pushed = true;
                sound.Play();
            }
            // ���� ���¿��� �浹
            else
            {
                pushed = false;
                sound.Stop();
            }
        }
        
    }
}
