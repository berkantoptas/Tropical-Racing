using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ButtonOption : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject selectCamera;

    public GameObject mainMenuUI;
    public GameObject optionsMenuUI;
    public GameObject carSelectMenuUI;
    public GameObject modeSelectMenuUI;
    public GameObject trackSelectMenuUI;

    public GameObject car1;
    public GameObject car2;
    public GameObject car3;
    public GameObject car4;

    public GameObject colorPanel;
    public GameObject ScoreModeTimes;

    public AudioMixer audioMixer;

    private int menuChangeMode = 0;

    void Update()
    {
        if (menuChangeMode == 1)
        {
            StartCoroutine(MenuChange());
        }
        if (menuChangeMode == 2)
        {
            StartCoroutine(MenuChange());
        }
    }

    public void PlayGame()
    {
        mainMenuUI.SetActive(false);
        carSelectMenuUI.SetActive(true);
        mainCamera.GetComponent<Animator>().enabled = true;
        selectCamera.GetComponent<Animator>().enabled = false;
        if (menuChangeMode != 0)
            selectCamera.transform.Rotate(-10, 10, 0);
        menuChangeMode = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Options()
    {
        mainMenuUI.SetActive(false);
        optionsMenuUI.SetActive(true);
    }

    public void BackButton()
    {
        carSelectMenuUI.SetActive(false);
        mainMenuUI.SetActive(true);
        selectCamera.GetComponent<Animator>().enabled = true;
        mainCamera.GetComponent<Animator>().enabled = false;
        mainCamera.transform.Rotate(10, -10, 0);
        menuChangeMode = 2;
    }

    public void BackButton2()
    {
        modeSelectMenuUI.SetActive(false);
        carSelectMenuUI.SetActive(true);
        ScoreModeTimes.SetActive(false);
    }

    public void BackButton3()
    {
        trackSelectMenuUI.SetActive(false);
        modeSelectMenuUI.SetActive(true);
        ScoreModeTimes.SetActive(false);
    }

    public void BackButtton4()
    {
        optionsMenuUI.SetActive(false);
        mainMenuUI.SetActive(true);  
    }

    IEnumerator MenuChange()
    {
        if(menuChangeMode==1)
        {
            yield return new WaitForSeconds(1);
            mainCamera.SetActive(false);
            selectCamera.SetActive(true);
            selectCamera.transform.position = new Vector3(-40.61f, 1.83f, 3.97f);
        }
        
        if (menuChangeMode==2)
        {
            yield return new WaitForSeconds(1);
            selectCamera.SetActive(false);
            mainCamera.SetActive(true);
            mainCamera.transform.position = new Vector3(-11.77f, 1.83f, 8.31f);
        }
    }

    public void LeftArrow()
    {
        if(GlobalCar.CarType > 1)
            GlobalCar.CarType--;

        colorPanel.SetActive(false);

        if (GlobalCar.CarType == 1)
        {
            car1.SetActive(true);
            car2.SetActive(false);
        }
            
        if (GlobalCar.CarType == 2)
        {
            car2.SetActive(true);
            car3.SetActive(false);
        }
            
        if (GlobalCar.CarType == 3)
        {
            car3.SetActive(true);
            car4.SetActive(false);
        }
    }

    public void RightArrow()
    {
        if(GlobalCar.CarType < 4)
            GlobalCar.CarType++;

        colorPanel.SetActive(false);

        if (GlobalCar.CarType == 2)
        {
            car2.SetActive(true);
            car1.SetActive(false);
        }

        if (GlobalCar.CarType == 3)
        {
            car3.SetActive(true);
            car2.SetActive(false);
        }

        if (GlobalCar.CarType == 4)
        {
            car4.SetActive(true);
            car3.SetActive(false);
        }
    }

    public void SelectColor()
    {
        colorPanel.SetActive(true);
    }

    public void NextButton()
    {
        carSelectMenuUI.SetActive(false);
        modeSelectMenuUI.SetActive(true);
    }

    public void RaceModeButton()
    {
        modeSelectMenuUI.SetActive(false);
        trackSelectMenuUI.SetActive(true);
    }

    public void ScoreModeButton()
    {
        ScoreModeTimes.SetActive(true);
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

}