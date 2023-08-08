using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TVButton : MonoBehaviour
{
    private bool pushed = false;
    AudioSource sound;
    private Button btn;

    void Start()
    {
        btn = GetComponent<Button>();
        sound = GetComponent<AudioSource>();
        btn.onClick.AddListener(OnOff);
    }

    private void OnOff()
    {
        if (!pushed)
        {
            sound.Play();
            pushed = true;
        }
        else
        {
            sound.Stop();
            pushed = false;
        }
    }

    void Update()
    {

    }

    
}
