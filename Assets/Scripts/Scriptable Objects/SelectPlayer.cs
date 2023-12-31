using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Select Player", menuName = "GAMESS/New Select Player")]
public class SelectPlayer : ScriptableObject
{
    public string RemotePlayer; 

    public void PlayerSelect(int index)
    {
        switch (index)
        {
            case 0:
                RemotePlayer = "RemotePlayer";
            break;
            case 1:
                RemotePlayer = "RemotePlayer_Hat";
            break;
            case 2:
                RemotePlayer = "RemotePlayer_Mustache";
            break;
            case 3:
                RemotePlayer = "RemotePlayer_Viking";
            break;
            default:
            break;
        }

        Debug.Log(RemotePlayer);
    }

}