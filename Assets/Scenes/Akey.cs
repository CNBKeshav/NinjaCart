﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Akey : MonoBehaviour
{
    public string SceneToLoad;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") == true)
        {
            SceneManager.LoadScene(SceneToLoad);
        }
    }
}
