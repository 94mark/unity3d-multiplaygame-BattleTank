using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PhotonInit : MonoBehaviourPunCallbacks
{
    public string version = "v1.0";
    // Start is called before the first frame update
    void Awake()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    private void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.NetworkClientState.ToString());
    }
    public override void OnConnectedToMaster() // ���� Ŭ���忡 ������ �� �Ǹ� ȣ��Ǵ� �ݹ��Լ�
    {
        base.OnConnectedToMaster();
        Debug.Log("Entered Lobby");
        PhotonNetwork.JoinRandomRoom();
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        base.OnJoinRandomFailed(returnCode, message);
        Debug.Log("No Room!");
        PhotonNetwork.CreateRoom("MyRoom", new RoomOptions { MaxPlayers = 20 }); //�ִ� 20�� �� �������
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        Debug.Log("Enter Room");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}