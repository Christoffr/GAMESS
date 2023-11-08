using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using BNG;
using System.Runtime.CompilerServices;


public class ButtonResetBoards : MonoBehaviour
{
    [SerializeField] private PhotonView _photonview;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DestroyObjectByName(string name)
    {
        Debug.Log("Button Clicked!");
        _photonview.RPC("SyncDestroyObjectByName", RpcTarget.AllBuffered, name);
    }

    [PunRPC]
    void SyncDestroyObjectByName(string name)
    {
        Debug.Log("Sync Destroy Obejct By Name");
        GameObject objectToDestroy = GameObject.Find(name);

        if (objectToDestroy != null)
        {
            Destroy(objectToDestroy);
        }
    }
}
