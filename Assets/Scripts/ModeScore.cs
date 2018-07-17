using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ModeScore : MonoBehaviour
{

    public int ModeSelection;
    public GameObject RaceUI;
    public GameObject ScoreUI;
    public GameObject AICar;
    public static int CurrentScore;
    public int InternalScore;
    public GameObject ScoreValue;
    public GameObject ScoreObjects;
    public GameObject ScoreModeTime;



    void Start()
    {
        ModeSelection = ModeSelect.RaceMode;

        if (ModeSelection == 1)
        {
            RaceUI.SetActive(false);
            ScoreUI.SetActive(true);
            AICar.SetActive(false);
            ScoreObjects.SetActive(true);
            ScoreModeTime.GetComponent<Text>().text = "" + TimeSelect.ScoreModeTime.ToString("F0");
        }

    }

    void Update()
    {
        InternalScore = CurrentScore;
        ScoreValue.GetComponent<Text>().text = "" + InternalScore;
        
    }

}
