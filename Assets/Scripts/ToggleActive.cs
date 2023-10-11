using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.Events;

public class ToggleActive : MonoBehaviour
{

    // Declare event
    public UnityEvent OnToggleEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Invoke event when toggled
    public void OnToggle()
    {
        OnToggleEvent?.Invoke();
    }
}
