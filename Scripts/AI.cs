using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

    public float speed = 10;
    public Transform theBall;

    void Start() {
        theBall = GameObject.FindGameObjectWithTag("Ball").transform;
    }

    void Update () {
		
	}

}
