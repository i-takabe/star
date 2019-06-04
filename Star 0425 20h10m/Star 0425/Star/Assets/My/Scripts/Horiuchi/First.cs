using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First : MonoBehaviour
{
    private GameObject 
        bgm,
        se;
    public GameObject 
        bgmTitle,
        buttonSE;
    // Start is called before the first frame update
    void Start()
    {
        SelectStage.StageSelectNumber = SelectStage.minStageNumber;

        bgm = GameObject.Find("BGM");
        if (bgm == null)
        {
            bgm = Instantiate(bgmTitle, Vector3.zero, Quaternion.identity);
            bgm.name = "BGM";
        }
        bgm = GameObject.Find("ButtonSE");
        if (bgm == null)
        {
            se = Instantiate(buttonSE, Vector3.zero, Quaternion.identity);
            se.name = "ButtonSE";
        }
    }
}
