﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugPC : MonoBehaviour
{
    public static bool pc;
    // Start is called before the first frame update
    void Start()
    {
        pc = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            pc = true;
    }
    void Awake()
    {
        Application.targetFrameRate = 60;
    }
}
