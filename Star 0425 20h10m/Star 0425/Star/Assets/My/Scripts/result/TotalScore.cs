using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    public static bool IsClear
    {
        get; set;
    }
    private int
        stockTotal,
        hundred,
        thousand,
        million;
    private const int
        oneMillion = 1000000,
        oneThousand = 1000;
    public void ShowTotalScore(Text ScoreText)
    {
        if (IsClear == true)
        {
            stockTotal = ScoreSet();
            million = stockTotal / oneMillion;
            thousand = (stockTotal - million * oneMillion) / oneThousand;
            hundred = stockTotal - (million * oneMillion + thousand * oneThousand);
            if (stockTotal >= oneMillion)
                ScoreText.text = million + "," + thousand.ToString("d3") + "," + hundred.ToString("d3");
            else if(stockTotal >= oneThousand)
                ScoreText.text = thousand + "," + hundred.ToString("d3");
            else
                ScoreText.text = hundred.ToString();
        }
        else
        {
            ScoreText.text = "NO SCORE";
        }
    }
    public int ScoreSet()
    { 
        return (int)(GameGenerator.Star * 1000000 / GameGenerator.StageTimer);
    }
}
