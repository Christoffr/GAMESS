using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.PlayerLoop;
using Photon.Pun;
using BNG;


public class ResetObject : MonoBehaviour
{
   [SerializeField] private ButtonResetObject buttonResetObject;
    private Vector3 _initialPosition;
    private Quaternion _initialRotation;
    private Vector3 _initialScale;
    private PhotonView _photonView;

    void Start()
    {
        _photonView = GetComponent<PhotonView>();
        buttonResetObject.OnResetButton.AddListener(ResetToInitialTransform);

        if (_photonView.IsMine)
        {
            Initialize();
            
        }
    }

    void Update()
    {
        if (_photonView.IsMine && InputBridge.Instance.BButtonDown)
        {
            ResetToInitialTransform();
        }
    }


    void OnDisable()
    {
       buttonResetObject.OnResetButton.RemoveListener(ResetToInitialTransform);
    }
        void Initialize()
    {
        _initialPosition = transform.position;
        _initialRotation = transform.rotation;
        _initialScale = transform.localScale;
    }

    void ResetToInitialTransform()
    {
        transform.position = _initialPosition;
        transform.rotation = _initialRotation;
        transform.localScale = _initialScale;

        // If PhotonView doesn't automatically sync transform changes, you might need to update it explicitly:
        //_photonView.RPC("SyncTransform", RpcTarget.OthersBuffered, transform.position, transform.rotation, transform.localScale);
    }

    [PunRPC]
    void SyncTransform(Vector3 position, Quaternion rotation, Vector3 scale)
    {
        // This method is called on remote clients to sync the transform changes
        transform.position = position;
        transform.rotation = rotation;
        transform.localScale = scale;
    }
}
