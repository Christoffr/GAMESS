using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Unity.VisualScripting;

public class IsActive : MonoBehaviour
{
    [SerializeField] private bool _isActive = true;
    private PhotonView _photonView;
    // Start is called before the first frame update
    void Start()
    {
        _photonView = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetGameobjectActive()
    {
        _isActive = !_isActive;
        gameObject.SetActive(_isActive);
        
        // Syncronize over network 
        _photonView.RPC("SyncActive", RpcTarget.OthersBuffered, _isActive);
    }

    [PunRPC]
    void SyncActive(bool _active)
    {
        gameObject.SetActive(_active);
    }

}
