using Photon.Pun;
using UnityEngine;

public class Visibility : MonoBehaviourPunCallbacks
{
    [SerializeField] private GameObject controlPanel;
    //[SerializeField] private PhotonView photonView;

    private void Start()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            Debug.Log("Is Master Client");
            controlPanel.SetActive(true);
        }
        else
        {
            controlPanel.SetActive(false);
        }
    }
}
