﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScreen4 : MonoBehaviour
{
    [SerializeField]
    private string sceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Portal"))
        {
            FindObjectOfType<Screen4Loader>().LoadScene4(sceneToLoad);
        }
    }
}