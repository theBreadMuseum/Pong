using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public KeyCode moveUp;
    public KeyCode moveDown;

    public float speed = 10;
	
	void Update () {
		
        if(Input.GetKey(moveUp)) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, speed);
        } 
        else if(Input.GetKey(moveDown)) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, speed * -1);
        }
        else {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, 0);
        }

	}
}
