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

    public void DestroyObjectByTag(string tag)
    {
        _photonview.RPC("SyncDestroyObjectByTag", RpcTarget.AllBuffered, tag);
    }

    [PunRPC]
    void SyncDestroyObjectByTag(string tag)
    {
        //GameObject objectToDestroy = GameObject.Find(name);

        foreach (var objectToDestroy in GameObject.FindGameObjectsWithTag(tag))
        {
            if (objectToDestroy != null)
            {
                Destroy(objectToDestroy);
            }   
        }
    }
}
