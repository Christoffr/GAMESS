using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using BNG;

public class RepresentPlayer : MonoBehaviourPunCallbacks
{

    [SerializeField] SelectPlayer selectedPlayer;
    void Start()
    {
        // Network Instantiate the object used to represent our player. This will have a View on it and represent the player         
        GameObject player = PhotonNetwork.Instantiate(selectedPlayer.RemotePlayer, new Vector3(0f, 0f, 0f), Quaternion.identity, 0);
        BNG.NetworkPlayer np = player.GetComponent<BNG.NetworkPlayer>();
        if (np) 
        {
            np.transform.name = "MyRemotePlayer";
            np.AssignPlayerObjects();
            Debug.Log("NetworkPlayer component found on " + np.transform.name);
        }
        else
        {
            Debug.Log("NetworkPlayer component not found on instantiated player");
        }
    }
}
