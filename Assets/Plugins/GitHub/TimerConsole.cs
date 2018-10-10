using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerConsole : MonoBehaviour {

    float timer;
    int increase;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;
        //The Float variable will increase with the time
        if (timer >= increase + 1)
        {
            increase += 1;
            print(string.Format("{0} seconds", increase));

        }//Makes the int variable show one message per second everytime the float hits the same value as the int variable,
         //this will then add 1+ on the int making the whole process go over and over again and counting the time at the same time
	}
}
