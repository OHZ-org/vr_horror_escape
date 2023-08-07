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
            // 꺼진 상태에서 충돌
            if (!pushed)
            {
                pushed = true;
                sound.Play();
            }
            // 켜진 상태에서 충돌
            else
            {
                pushed = false;
                sound.Stop();
            }
        }
        
    }
}
