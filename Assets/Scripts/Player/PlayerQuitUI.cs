using UnityEngine;
using BNG;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class PlayerQuitUI : MonoBehaviourPunCallbacks
{


    [SerializeField]  GameObject _playerQuitUI;
    
    private bool _isVisable = false;


    // Start is called before the first frame update
    void Start()
    {
        _playerQuitUI.SetActive(_isVisable);
    }

    // Update is called once per frame
    void Update()
    {
        if (InputBridge.Instance.AButtonDown)
        {
            _isVisable = !_isVisable;

            _playerQuitUI.SetActive(_isVisable);
        }
    }

    public void LeaveRoomAndQuit()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnLeftRoom()
    {
       /* #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();*/
        PhotonNetwork.LoadLevel(0);
    }
}
