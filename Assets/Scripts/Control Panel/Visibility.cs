using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class Visibility : MonoBehaviour
{
    [SerializeField] private GameObject controlPanel;
    [SerializeField] private PhotonView photonView;

    private void Start()
    {
        if (photonView.IsMine)
        {
            controlPanel.SetActive(true);
        }
        else
        {
            controlPanel.SetActive(false);
        }
    }
}
