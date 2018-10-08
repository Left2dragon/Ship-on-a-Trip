﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warping : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < -9)
        {
            transform.position = new Vector3(9, transform.position.y);
        }
        if (transform.position.x > 9)
        {
            transform.position = new Vector3(-9, transform.position.y);
        }
        if (transform.position.y < -5)
        {
            transform.position = new Vector3(transform.position.x, 5);
        }
        if (transform.position.y > 5)
        {
            transform.position = new Vector3(transform.position.x, -5);
        }
	}//Makes the ship warp to the screens parallel side
}
