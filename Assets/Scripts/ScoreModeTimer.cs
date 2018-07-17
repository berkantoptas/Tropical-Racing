using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class ScoreModeTimer : MonoBehaviour {

    public GameObject MyCar;
    public GameObject LevelMusic;

    public GameObject CountDown;
    public GameObject FinishMusic;

    public static string ScoreTimeDisplay;
    public static float MilliCount;
    public static float ScoreTimeCount;

    public GameObject ScoreModeTime;

    public GameObject GamePanel;
    public GameObject FinishPanel;
    public GameObject MiniMapObject;

    public GameObject FinishScore;

    public GameObject NormalCam;
    public GameObject FinishCamera;

    void Update()
    {
        MilliCount += Time.deltaTime;
        ScoreTimeCount = TimeSelect.ScoreModeTime - MilliCount;
        ScoreTimeDisplay = ScoreTimeCount.ToString("F0");

        if (ScoreTimeCount <= 5)
        {
            CountDown.SetActive(true);
            if (ScoreTimeCount <= 0)
            {
                FinishMusic.SetActive(true);
                MyCar.SetActive(false);
                CarController.m_Topspeed = 0.0f;
                MyCar.GetComponent<CarController>().enabled = false;
                MyCar.GetComponent<CarUserControl>().enabled = false;
                MyCar.GetComponent<AudioSource>().enabled = false;
                MyCar.SetActive(true);
                LevelMusic.SetActive(false);
                ScoreModeTime.SetActive(false);
                GamePanel.SetActive(false);
                NormalCam.SetActive(false);
                FinishCamera.SetActive(true);
                FinishScore.GetComponent<Text>().text = "" + ModeScore.CurrentScore;
                FinishPanel.SetActive(true);
                MiniMapObject.SetActive(false);
            }
        }
        ScoreModeTime.GetComponent<Text>().text = "" + ScoreTimeDisplay;
    }
}
