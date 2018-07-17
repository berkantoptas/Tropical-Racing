using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointScore2 : MonoBehaviour {

    public GameObject HalfLapTrig2;
    public GameObject ScoreObjects3;


    void OnTriggerEnter()
    {
        HalfLapTrig2.SetActive(false);
        ScoreObjects3.SetActive(true);
    }

}
