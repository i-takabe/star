﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartButton : MonoBehaviour
{
    public GameObject dialog;
    public GameObject backB;
    public GameObject bgm;
    private GameObject setBgm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void retryDia()
    {
        backB.SetActive(false);
        dialog.SetActive(true);
    }
    public void diaClose()
    {
        backB.SetActive(true);
        dialog.SetActive(false);
    }

    public void loadS()
    {
        Time.timeScale = 1.0f;
        Resources.UnloadUnusedAssets();//一回全部消し飛ばすやつ　by亀
        SceneManager.LoadScene("LoadScene");
    }

    public void loadTitle()
    {
        Time.timeScale = 1.0f;
        setBgm = Instantiate(bgm, Vector3.zero, Quaternion.identity);
        setBgm.name = "BGM";
        SceneManager.LoadScene("SelectScene");
    }
}
