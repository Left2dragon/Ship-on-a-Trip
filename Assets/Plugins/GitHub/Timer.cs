using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timer;
    private float startTime;

	// Use this for initialization
	void Start () {
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

        float t = Time.time - startTime;
        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f0");
        //Makes the time go second by second with no decimals

        Debug.Log(string.Format("Timer: {0} Minutes {1} seconds" ,minutes , seconds));
        //Shows the timer on console
        timer.text = minutes + ":" + seconds;
        //Shows the time on screen
        
	}

}
