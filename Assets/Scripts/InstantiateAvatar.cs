using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class InstantiateAvatar : MonoBehaviourPunCallbacks
{

    [SerializeField] private GameObject _prefab;
    [SerializeField] private GameObject _parent;

    public override void OnJoinedRoom()
    {
        if (photonView.IsMine)
        {
            Debug.Log("Local player is instantiating and parenting.");
            // Instantiate the object for the local player
            GameObject newObj = PhotonNetwork.Instantiate(_prefab.name, _parent.transform.position, Quaternion.identity);

            // Parent the object to another GameObject
            newObj.transform.parent = _parent.transform;
        }
    }
}
