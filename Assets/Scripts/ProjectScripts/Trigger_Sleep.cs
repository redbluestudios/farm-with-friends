﻿using UnityEngine;
using System.Collections;

public class Trigger_Sleep : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            WorldTime worldtime = (WorldTime)GameObject.FindGameObjectWithTag ("GameManager").GetComponent<WorldTime> ();
            worldtime.GoToNextDay ();
        }
    }
}
