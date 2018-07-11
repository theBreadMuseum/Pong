using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour {

    private AudioSource audioSource;
    public AudioClip scoreSound;

    void OnTriggerEnter2D (Collider2D hitInfo) {
		if(hitInfo.name == "Ball") {
            var wallName = transform.name;
            GameMngr.Score(wallName);
            hitInfo.gameObject.SendMessage("ResetBallTimer");

            audioSource = GetComponent<AudioSource>();
            audioSource.clip = scoreSound;
            audioSource.Play();
        }
	}

}
