using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonResetObject : MonoBehaviour
{

    // Declare event 
    public UnityEvent OnResetButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Invoke event when button is pressed
    public void ButtonPress()
    {
        OnResetButton?.Invoke();
    }
}
