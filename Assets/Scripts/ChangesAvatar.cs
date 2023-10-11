using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;
using Photon.Pun;

public class ChangesAvatar : MonoBehaviourPun
{
    [SerializeField]
    private GameObject[] _prefabs;

    private int _count = 0;

    void Start()
    {
        if (photonView.IsMine)
        {
            // Only the local player should trigger the synchronization
            photonView.RPC("SyncInitialChanges", RpcTarget.AllBuffered, _count);
        }
    }

    void Update()
    {
        if (photonView.IsMine && InputBridge.Instance.AButtonDown)
        {
            _count++;

            if (_count >= _prefabs.Length)
                _count = 0;

            photonView.RPC("Changes", RpcTarget.AllBuffered, _count);
        }
    }

    [PunRPC]
    void SyncInitialChanges(int index)
    {
        // Apply initial changes for late-joining players
        Changes(index);
    }

    [PunRPC]
    void Changes(int index)
    {
        for (int i = 0; i < _prefabs.Length; i++)
        {
            if (i == index)
            {
                _prefabs[i].SetActive(true);
            }
            else
            {
                _prefabs[i].SetActive(false);
            }
        }
    }
}
