using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;
using System.Linq;
using TMPro;

public class ChangesAvatar : MonoBehaviour
{

    [SerializeField]
    private GameObject[] _prefabs;
    
    private int _count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (InputBridge.Instance.AButtonDown)
        {
            _count++;

            if(_count >= _prefabs.Length)
                _count = 0;

            for (int i = 0; i < _prefabs.Length; i++)
            {
                if(i == _count)
                {
                    _prefabs[i].SetActive(true);
                }
                else
                {
                    _prefabs[i].SetActive(false);
                }
            }
        }
    }
}
