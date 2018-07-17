using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour {

    public AudioSource FinishMusic;

    public GameObject WinText;
    public GameObject LoseText;
    public GameObject ESCText;

    public static bool RaceFinished = false; //false for not finish - true for finish

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "RaceFinishTrigger")
        {
            RaceFinished = true;
            FinishMusic.Play();
            ESCText.SetActive(true);
            if (this.gameObject.tag == "PlayerCar")
            {
                WinText.SetActive(true);
            }
            if (this.gameObject.tag == "AICar")
            {
                LoseText.SetActive(true);
            }
        }
    }


}
