using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;


public class Multi : MonoBehaviourPunCallbacks
{
    private readonly string version = "1.0f";

    private string userId = "1P";
    private void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.GameVersion = version;
        PhotonNetwork.NickName = userId;
        Debug.Log(PhotonNetwork.SendRate);
        //Debug.Log(userId);
        PhotonNetwork.ConnectUsingSettings();
    }
    
    //접속 후 호출 함수
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master!");
        Debug.Log($"PhotonNetwork@ InLobby = {PhotonNetwork.InLobby}");
        PhotonNetwork.JoinLobby(); //로비 입장
    }

    //로비 입장시 호출 함수
    public override void OnJoinedLobby()
    {
        Debug.Log($"PhotonNetwork@ InLobby = {PhotonNetwork.InLobby}");
    }


    void Start()
    {
    }

    void Update()
    {
        
    }
}
