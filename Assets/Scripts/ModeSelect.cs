using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour
{

    public static int RaceMode; // 0=Race, 1=Score


    public void RacingMode()
    {
        RaceMode = 0;
    }


    public void ScoreMode()
    {
        RaceMode = 1;
    }
}