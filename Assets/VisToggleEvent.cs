﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisToggleEvent : MonoBehaviour
{
    public delegate void VisToggle();
    public static event VisToggle Toggled;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //if player presses space, toggle the visibility of the attached object on or off
        {
            Toggled();
        }
    }
}
