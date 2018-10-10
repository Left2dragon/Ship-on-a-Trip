using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFunction : MonoBehaviour {

    public SpriteRenderer colorRend;
    public Color color;
    //Makes the sprite able to switch color
    public float speed;
    public float rotationSpeed = 180;
    public float Red;
    public float Blue;
    public float Green;
    public float positionX;
    public float positionY;
    

	// Use this for initialization
	void Start () {
        speed = Random.Range(1, 10);
        //Will randomize the speed of the sprite every time the player starts the game

        positionX = Random.Range(-8, 8);
        positionY = Random.Range(-5, 5);
        transform.Translate(positionX, positionY, 0);
	}   //Makes the sprite spawn in a random location every time the player starts the game
	
	// Update is called once per frame
	void Update () {

        transform.Translate(0, speed * Time.deltaTime, 0, Space.Self);
        //Makes the sprite go foward constantly

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Red = Random.Range(0, 1f);
            Blue = Random.Range(0, 1f);
            Green = Random.Range(0, 1f);
            colorRend.color = new Color(Red, Blue, Green);
        }//If key "space" gets pushed down the sprite will change to a randomized color

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, (rotationSpeed - 60) * Time.deltaTime);
            colorRend.color = Color.green;
        }//If key "A" gets pushed down the sprite will turn left, turn green and is slower than right turn

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
            colorRend.color = Color.blue;
        }//If key "D" gets pushed down the sprite will turn right and turn blue

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, (-speed / 2) * Time.deltaTime ,  0);
        }//If key "S" gets pushed down the sprite will go at its half of its current speed
		
	}
}
