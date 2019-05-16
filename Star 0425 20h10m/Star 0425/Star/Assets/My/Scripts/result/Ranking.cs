﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour
{
    private float stock, setStock;
    private const int maxRank = 3;
    private bool onece;
    // Start is called before the first frame update
    void Start()
    {
        stock = GameGenerator.StageTimer;
        onece = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Goal.ClearFlag && !onece)
        {
            for (int i = 1; i <= maxRank; i++)
            {
                if (PlayerPrefs.GetFloat("STAGE" + 1 + "RANK" + i, 0) > stock)
                {
                    setStock = PlayerPrefs.GetFloat("STAGE" + 1 + "RANK" + i, 0);
                    PlayerPrefs.SetFloat("STAGE" + 1 + "RANK" + i, stock);
                    stock = setStock;
                }
            }
            PlayerPrefs.Save();

            Text rankingScore = GetComponent<Text>();
            rankingScore.text =
                "1: " + PlayerPrefs.GetFloat("STAGE" + 1 + "RANK" + 1, 0).ToString("f2") + " sec\n" +
                "2: " + PlayerPrefs.GetFloat("STAGE" + 1 + "RANK" + 2, 0).ToString("f2") + " sec\n" +
                "3: " + PlayerPrefs.GetFloat("STAGE" + 1 + "RANK" + 2, 0).ToString("f2") + " sec\n";

            onece = true;
        }
    }
}