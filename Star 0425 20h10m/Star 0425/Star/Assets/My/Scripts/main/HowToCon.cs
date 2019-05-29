using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToCon : MonoBehaviour
{
    public GameObject howTo;
    public GameObject other;
    public GameObject[] HTpre;

    private GameObject HTobj;
    private int selsectNum = 0;
    private bool flicKOK = false;
    HowtoController flick = new HowtoController();

    private void Update()
    {
        if (!flicKOK)
        {
            flick.Flicker();
            if (flick.flickDirection == (int)HowtoController.direction.right)
            {
                changeRightHT();
            }
            if (flick.flickDirection == (int)HowtoController.direction.left)
            {
                changeLeftHT();
            }
            flick.flickDirection = (int)HowtoController.direction.none;
        }
    }

    public void StartHowTo()
    {
        howTo.SetActive(true);
        other.SetActive(false);
        HTobj = Instantiate(HTpre[0], howTo.transform);
        HTobj.transform.SetSiblingIndex(2);
        flicKOK = true;
    }
    public void endHowTo()
    {
        Destroy(HTobj);
        howTo.SetActive(false);
        other.SetActive(true);
        flicKOK = false;
    }

    public void changeRightHT()
    {
        Destroy(HTobj);
        selsectNum++;
        if (selsectNum >= HTpre.Length)
        {
            selsectNum = 0;
        }
        HTobj = Instantiate(HTpre[selsectNum], howTo.transform);
        HTobj.transform.SetSiblingIndex(2);
    }
    public void changeLeftHT()
    {
        Destroy(HTobj);
        selsectNum--;
        if (selsectNum < 0)
        {
            selsectNum = HTpre.Length - 1;
        }
        HTobj = Instantiate(HTpre[selsectNum], howTo.transform);
        HTobj.transform.SetSiblingIndex(2);
    }


}
