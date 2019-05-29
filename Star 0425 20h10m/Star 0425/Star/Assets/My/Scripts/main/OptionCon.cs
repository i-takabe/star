using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionCon : MonoBehaviour
{
    public Sprite[] sprites = new Sprite[4];
    public GameObject OpCan;
    public GameObject otherCan;

    [SerializeField]
    private Image imgX;
    [SerializeField]
    private Image imgY;

    private Vector2 xy = new Vector2(1,1);
    private int x = 1;
    private int y = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(x == 1)
        {
            imgX.sprite = sprites[0];
        }
        else
        {
            imgX.sprite = sprites[1];
        }

        if (y == 1)
        {
            imgY.sprite = sprites[2];
        }
        else
        {
            imgY.sprite = sprites[3];
        }
    }

    public void changeAngleX()
    {
        x *= -1;
        PlayerMove.PM = new Vector2(x,y);
    }

    public void changeAngleY()
    {
        y *= -1;
        PlayerMove.PM = new Vector2(x, y);
    }

    public void openOption()
    {
        OpCan.SetActive(true);
        otherCan.SetActive(false);
    }

    public void closeOption()
    {
        OpCan.SetActive(false);
        otherCan.SetActive(true);
    }
}
