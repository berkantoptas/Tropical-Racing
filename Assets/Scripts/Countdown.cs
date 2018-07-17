using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class Countdown : MonoBehaviour
{

    public GameObject CountDown3;
    public GameObject CountDown2;
    public GameObject CountDown1;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public GameObject LapTimer;
    public GameObject CarControls;
    public AudioSource LevelMusic;

    public GameObject RedLight;
    public GameObject YellowLight;
    public GameObject GreenLight;

    public GameObject ScoreModeTimerObj; //

    void Start()
    {
        CarController.m_Topspeed = 80.0f;
        FinishTrigger.RaceFinished = false;
        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;
        LapTimeManager.RawTime = 0;

        ModeScore.CurrentScore = 0;
        ScoreModeTimer.ScoreTimeCount = 0;
        ScoreModeTimer.MilliCount = 0;

        EscMenu.Paused = 0;

        StartCoroutine(CountStart());
    }


    IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        CountDown3.GetComponent<Text>().text = "3";
        GetReady.Play();
        CountDown3.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown3.SetActive(false);
        CountDown2.GetComponent<Text>().text = "2";
        GetReady.Play();
        CountDown2.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown2.SetActive(false);
        RedLight.SetActive(false);
        YellowLight.SetActive(true);
        CountDown1.GetComponent<Text>().text = "1";
        GetReady.Play();
        CountDown1.SetActive(true);
        yield return new WaitForSeconds(1);
        CountDown1.SetActive(false);
        YellowLight.SetActive(false);
        GreenLight.SetActive(true);
        GoAudio.Play();
        LevelMusic.Play();
        LapTimer.SetActive(true);
        CarControls.SetActive(true);
        if(ModeSelect.RaceMode==1)
        {
            ScoreModeTimerObj.SetActive(true); //
        }

    }


}