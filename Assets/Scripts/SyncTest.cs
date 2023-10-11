using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;
using Photon.Pun;
using System;
using Random = UnityEngine.Random;

public class SyncTest : MonoBehaviour
{

    [SerializeField] private GameObject _cube;
    [SerializeField] private GameObject _prefab;
    private PhotonView _photonview;
    // Start is called before the first frame update
    void Start()
    {
        _photonview = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (InputBridge.Instance.BButtonDown)
        {
            float r = Random.Range(0f, 1f);
            float g = Random.Range(0f, 1f);
            float b = Random.Range(0f, 1f);

            _photonview.RPC("MyChangeColor", RpcTarget.AllBuffered, r,g,b);
        }
    }

    [PunRPC]
    void MyChangeColor(float r, float g, float b)
    {
        _cube.GetComponent<Renderer>().material.color = new Color(r, g, b, 1f);
        _prefab.GetComponent<Renderer>().material.color = new Color(r, g, b,  1f); 
    }
}
