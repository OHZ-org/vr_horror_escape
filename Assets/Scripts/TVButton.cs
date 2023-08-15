using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TVButton : MonoBehaviour
{
    private bool playing = false;
    AudioSource sound;
    private Button btn;
    Door2 door2;

    void Start()
    {
        btn = GetComponent<Button>();
        sound = GetComponent<AudioSource>();
        btn.onClick.AddListener(OnOff);
        door2 = GetComponentInParent<Door2>();
    }

    private void OnOff()
    {
        if (!playing)
        {
            sound.Play();
            playing = true;
        }
        else
        {
            sound.Stop();
            playing = false;
        }
    }

    void Update()
    {
        if (!door2.GetBool() && !playing)
        {
            sound.Play();
            playing = true;
        }
    }

    
}
