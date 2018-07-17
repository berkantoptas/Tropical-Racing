using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointScore : MonoBehaviour {


    public GameObject Lamp;
    public GameObject HalfLapTrig;
    public GameObject ScoreObjects2;

    public GameObject HalfLapTrig2;

    void OnTriggerEnter()
    {
        Lamp.SetActive(false);
        HalfLapTrig.SetActive(false);
        ScoreObjects2.SetActive(true);
        HalfLapTrig2.SetActive(true);
    }


}
