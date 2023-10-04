using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using BNG;


public class ButtonResetBoards : MonoBehaviour
{
    private string objectName = "MarkerLineHolder";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (InputBridge.Instance.AButtonDown)
        {
            DestroyObjectByName(objectName);
        }   
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
