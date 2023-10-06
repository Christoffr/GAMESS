using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;
using Photon.Pun;

public class LoadTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         PhotonNetwork.AutomaticallySyncScene = true;
    }

    // Update is called once per frame
    void Update()
    {
        if ( InputBridge.Instance.YButtonDown)
        {
            PhotonNetwork.LoadLevel("GAMES");
        }
    }
}
