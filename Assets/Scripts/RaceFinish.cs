using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour
{

    public GameObject MyCar;
    public GameObject AICar;
    public GameObject FinishCam;
    public GameObject ViewModes;
    public GameObject LevelMusic;
    public GameObject CompleteTrig;
    public GameObject LapTimeManager;

    void OnTriggerEnter(Collider other)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        MyCar.SetActive(false);
        AICar.SetActive(false);
        CompleteTrig.SetActive(false);
        CarController.m_Topspeed = 0.0f;
        MyCar.GetComponent<CarController>().enabled = false;
        MyCar.GetComponent<CarUserControl>().enabled = false;
        AICar.GetComponent<CarController>().enabled = false;
        AICar.GetComponent<CarAIControl>().enabled = false;
        MyCar.GetComponent<AudioSource>().enabled = false;
        AICar.GetComponent<AudioSource>().enabled = false;
        MyCar.SetActive(true);
        AICar.SetActive(true);
        LevelMusic.SetActive(false);
        ViewModes.SetActive(false);
        LapTimeManager.SetActive(false);
        FinishCam.SetActive(true);



    }
}
