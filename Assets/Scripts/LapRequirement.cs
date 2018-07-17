using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapRequirement : MonoBehaviour {

    void Start()
    {
        this.GetComponent<Text>().text = "/ " + TrackSelect.LapCount;
    }

}
