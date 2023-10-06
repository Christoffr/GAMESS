using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using BNG;


public class ButtonResetBoards : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DestroyObjectByName(string name)
    {
        GameObject objectToDestroy = GameObject.Find(name);

        if (objectToDestroy != null)
        {
            Destroy(objectToDestroy);
        }
    }
}
