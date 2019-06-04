﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseController : MonoBehaviour
{
    [SerializeField]
    private GameObject pauseUI;
    [SerializeField]
    private GameObject mainUI;
    private VolumeControl1 volumeControl;

    private void Start()
    {
        volumeControl = GameObject.Find("BGMEvent2").GetComponent<VolumeControl1>();
    }

    public void pause()
    {
        pauseUI.SetActive(true);
        mainUI.SetActive(false);
        Time.timeScale = 0f;
        for (int i = 0; i < volumeControl.musicStep.Length; i++)
            volumeControl.musicStep[i].volume = 0;
        volumeControl.pauseSwich = true;
    }

    public void start()
    {
        pauseUI.SetActive(false);
        mainUI.SetActive(true);
        Time.timeScale = 1f;
        volumeControl.pauseSwich = false;
        for (int i = 0; i < volumeControl.pauseMusicStep.Length; i++)
        {
            volumeControl.pauseMusicStep[i].volume = 0;
            volumeControl.musicStep[i].volume = volumeControl.firstVolume;// 一気に流す
        }
        
    }
}
