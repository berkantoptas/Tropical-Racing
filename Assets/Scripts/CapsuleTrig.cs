using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class CapsuleTrig : MonoBehaviour {

    public GameObject RingRed;
    public GameObject RingGreen;

    public AudioSource RingRedMusic;
    public AudioSource RingGreenMusic;

    public GameObject RingRedText;
    public GameObject RingGreenText;


    private int skillType = 0; //1 for red 2 for green

    void Update()
    {
        if (skillType != 0)
        {
            StartCoroutine(SpeedRing());
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "RedTrigCapsule")
        {
            if (this.gameObject.tag == "PlayerCar")
            {
                RingRedMusic.Play();
                RingRedText.SetActive(true);

                CarController.m_Topspeed = 60.0f;
                skillType = 1;
            }
            if (this.gameObject.tag == "AICar")
            {
                CarController.m_Topspeed = 60.0f;
                skillType = 1;
            }
        }
        if (other.gameObject.name == "GreenTrigCapsule")
        {
            if (this.gameObject.tag == "PlayerCar")
            {
                RingGreenMusic.Play();
                RingGreenText.SetActive(true);

                CarController.m_Topspeed = 100.0f;
                skillType = 2;
            }
            if (this.gameObject.tag == "AICar")
            {
                CarController.m_Topspeed = 100.0f;
                skillType = 2;
            }
        }
    }

    void OnTriggerExit()
    {
        if (skillType == 1)
            RingRed.SetActive(false);
        if (skillType == 2)
            RingGreen.SetActive(false);
        skillType = 0;
    }

    IEnumerator SpeedRing()
    {
        if (skillType == 1)
        {
            yield return new WaitForSeconds(5);
            CarController.m_Topspeed = 80.0f;
            RingRedText.SetActive(false);
            skillType = 0;
        }
        if (skillType == 2)
        {
            yield return new WaitForSeconds(5);
            CarController.m_Topspeed = 80.0f;
            RingGreenText.SetActive(false);
            skillType = 0;
        }
    }


}
