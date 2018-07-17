using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject Car1;
    public GameObject Car2;
    public GameObject Car3;
    public GameObject Car4;
    public int CarImport;


    void Start()
    {
        CarImport = GlobalCar.CarType;      

        if (CarImport == 1)
        {
            Car1.SetActive(true);
        }

        if (CarImport == 2)
        {
            Car2.SetActive(true);
        }

        if (CarImport == 3)
        {
            Car3.SetActive(true);
        }

        if (CarImport == 4)
        {
            Car4.SetActive(true);
        }
    }


}