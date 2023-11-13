using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OwnershipTransfer : MonoBehaviourPun, IPunOwnershipCallbacks
{
    private void Awake()
    {
        PhotonNetwork.AddCallbackTarget(this);
    }

    private void OnDestroy()
    {
        PhotonNetwork.RemoveCallbackTarget(this);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Interactable")
        {
            Debug.Log("Trigger!");
            collider.GetComponent<PhotonView>().RequestOwnership(); 
        }
    }

    public void OnOwnershipRequest(PhotonView targetView, Player requestingPlayer)
    {
        Debug.Log("Ownership Request");
        if (targetView != base.photonView)
            return;

        base.photonView.TransferOwnership(requestingPlayer);
    }

    public void OnOwnershipTransfered(PhotonView targetView, Player previousOwner)
    {
        Debug.Log("Ownership Trafered");
        if (targetView != base.photonView)
            return;
    }

    public void OnOwnershipTransferFailed(PhotonView targetView, Player senderOfFailedRequest)
    {
        Debug.Log("Ownership Tranfer Failed");
    }
}
