using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour
{
    public static int CarType = 1; //

    public void Car1()
    {
        CarType = 1;
    }

    public void Car2()
    {
        CarType = 2;
    }

    public void Car3()
    {
        CarType = 3;
    }

    public void Car4()
    {
        CarType = 4;
    }
}