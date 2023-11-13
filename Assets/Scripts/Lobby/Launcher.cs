using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using UnityEngine.UI;
using Photon.Realtime;
using BNG;

public class Launcher : MonoBehaviourPunCallbacks
{
    public static Launcher Instance;
    [SerializeField] InputField roomNameInputField;
    [SerializeField] TMP_Text roomNameText;
    [SerializeField] TMP_Text errorText;
    [SerializeField] Transform roomListContent;
    [SerializeField] GameObject roomListItemPrefab;
    
    void Awake()
    {
        Instance = this;
    }
    
    void Start()
    {
        // Connect to Master Server using predefined settings
        Debug.Log("Connecting to Master Server...");
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master Server");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joined Lobby");
        MenuManager.Instance.OpenMenu("title");
    }

    public void CreateRoom()
    {
        if (string.IsNullOrEmpty(roomNameInputField.text))
        {
            return;
        }
        PhotonNetwork.CreateRoom(roomNameInputField.text);
        MenuManager.Instance.OpenMenu("loading");
    }

    public override void OnJoinedRoom()
    {
        //MenuManager.Instance.OpenMenu("room");
        //roomNameText.text = PhotonNetwork.CurrentRoom.Name;
        MenuManager.Instance.OpenMenu("loading");
        
        /*// Network Instantiate the object used to represent our player. This will have a View on it and represent the player         
        GameObject player = PhotonNetwork.Instantiate("RemotePlayer", new Vector3(0f, 0f, 0f), Quaternion.identity, 0);
        BNG.NetworkPlayer np = player.GetComponent<BNG.NetworkPlayer>();
        if (np) 
        {
            np.transform.name = "MyRemotePlayer";
            np.AssignPlayerObjects();
            Debug.Log("NetworkPlayer component found on " + np.transform);
        }
        else
        {
            Debug.Log("NetworkPlayer component not found on instantiated player.");
        }*/

        PhotonNetwork.LoadLevel(1);
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        MenuManager.Instance.OpenMenu("error");
        errorText.text = "Room Creation Failed: " + message;

    }

    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
        MenuManager.Instance.OpenMenu("loading");
    }

    public void JoinRoom(RoomInfo roomInfo)
    {
        PhotonNetwork.JoinRoom(roomInfo.Name);
        MenuManager.Instance.OpenMenu("loading");
    }

    public override void OnLeftRoom()
    {
        MenuManager.Instance.OpenMenu("title");
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        // Depopulate the list
        foreach (Transform item in roomListContent)
        {
            Destroy(item.gameObject);
        }

        // Populate the list
        for (int i = 0; i < roomList.Count; i++)
        {
            Instantiate(roomListItemPrefab, roomListContent).GetComponent<RoomListItem>().Setup(roomList[i]);   
        }
    }
}
