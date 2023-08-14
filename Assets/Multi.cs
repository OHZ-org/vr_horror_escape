using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;


public class Multi : MonoBehaviour
{
   
    void Start()
    {
        Screen.SetResolution(960, 600, false);
        PhotonNetwork.ConnectUsingSettings();
    }

    void Update()
    {
        
    }
}
