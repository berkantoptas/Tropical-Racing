using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeSelect : MonoBehaviour {

    public static int ScoreModeTime = 30;

    public void Time30()
    {
        ScoreModeTime = 30;
        SceneManager.LoadScene(5);
    }
    public void Time60()
    {
        ScoreModeTime = 60;
        SceneManager.LoadScene(5);
    }
    public void Time90()
    {
        ScoreModeTime = 90;
        SceneManager.LoadScene(5);
    }
    public void Time120()
    {
        ScoreModeTime = 120;
        SceneManager.LoadScene(5);
    }

}
