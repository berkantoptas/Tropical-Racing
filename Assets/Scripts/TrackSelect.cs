using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrackSelect : MonoBehaviour {

    public static int LapCount = 1;
    public GameObject Tracks;

    public void Track01()
    {
        SceneManager.LoadScene(1);
    }

    public void Track02()
    {
        SceneManager.LoadScene(2);
    }

    public void Track03()
    {
        SceneManager.LoadScene(3);
    }

    public void Track04()
    {
        SceneManager.LoadScene(4);
    }

    public void LapCount1()
    {
        LapCount = 1;
        Tracks.SetActive(true);
    }
    public void LapCount2()
    {
        LapCount = 2;
        Tracks.SetActive(true);
    }
    public void LapCount3()
    {
        LapCount = 3;
        Tracks.SetActive(true);
    }
    public void LapCount4()
    {
        LapCount = 4;
        Tracks.SetActive(true);
    }

}
