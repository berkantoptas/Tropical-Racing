using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Vehicles.Car;

public class EscMenu : MonoBehaviour {

    public GameObject Panel;
    public GameObject MiniMap;
    public GameObject PauseMenu;
    public GameObject MyCar;
    public GameObject AICar;
    public GameObject LapTimeManager;
    public AudioSource LevelMusicPause;
    public AudioSource PauseMusic;

    public static int Paused = 0;

    void Update () {
        if (Input.GetButtonDown("Cancel"))
        {
            if(Paused == 0)
            {
                Paused = 1;
                if (ModeSelect.RaceMode == 0)
                {
                    if(FinishTrigger.RaceFinished==true)
                    {
                        CarController.m_Topspeed = 80.0f;
                        SceneManager.LoadScene(0);
                    }
                    else
                    {
                        Panel.SetActive(false);
                        MiniMap.SetActive(false);
                        PauseMenu.SetActive(true);

                        MyCar.SetActive(false);
                        AICar.SetActive(false);
                        PauseMusic.Play();
                        CarController.m_Topspeed = 0.0f;
                        MyCar.GetComponent<CarController>().enabled = false;
                        MyCar.GetComponent<CarUserControl>().enabled = false;
                        AICar.GetComponent<CarController>().enabled = false;
                        AICar.GetComponent<CarAIControl>().enabled = false;
                        MyCar.GetComponent<AudioSource>().enabled = false;
                        AICar.GetComponent<AudioSource>().enabled = false;

                        MyCar.SetActive(true);
                        AICar.SetActive(true);

                        LapTimeManager.SetActive(false);
                    }
                }
                else
                    SceneManager.LoadScene(0);
            }
            else if(Paused == 1)
            {
                Paused = 0;
                if (ModeSelect.RaceMode == 0)
                {
                    Panel.SetActive(true);
                    MiniMap.SetActive(true);
                    PauseMenu.SetActive(false);
                    PauseMusic.Stop();
                    MyCar.SetActive(false);
                    AICar.SetActive(false);
                    CarController.m_Topspeed = 80.0f;
                    MyCar.GetComponent<CarController>().enabled = true;
                    MyCar.GetComponent<CarUserControl>().enabled = true;
                    AICar.GetComponent<CarController>().enabled = true;
                    AICar.GetComponent<CarAIControl>().enabled = true;
                    MyCar.GetComponent<AudioSource>().enabled = true;
                    AICar.GetComponent<AudioSource>().enabled = true;
                    MyCar.SetActive(true);
                    AICar.SetActive(true);
                    LevelMusicPause.Play();
                    LapTimeManager.SetActive(true);
                }
                else
                    SceneManager.LoadScene(0);
            }
        }
    }

    public void MainMenu()
    {
        CarController.m_Topspeed = 80.0f;
        SceneManager.LoadScene(0);
    }
}
