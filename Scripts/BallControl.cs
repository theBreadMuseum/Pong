using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    public int ballStartSpeed = 90;

    void Start() {
        StartCoroutine(BallStartTimer());
    }

    void Update() {
        float xVel = GetComponent<Rigidbody2D>().velocity.x;
        if((xVel < 16 || xVel > 16) && xVel !=0) {
            if(xVel > 0) {
                GetComponent<Rigidbody2D>().velocity = new Vector2(18f, GetComponent<Rigidbody2D>().velocity.y);
            }
            else {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-18f, GetComponent<Rigidbody2D>().velocity.y);
            }
        }
    }

    IEnumerator ResetBallTimer() {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);

        transform.position = new Vector2(0f, 0f);

        yield return new WaitForSeconds(0.5f);
        BallStart();
    }

    IEnumerator BallStartTimer() {
        yield return new WaitForSeconds(2);
        BallStart();
    }

    void BallStart() {
        float randomNumber = Random.Range(0f, 1f);
        if (randomNumber <= 0.5f) {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(ballStartSpeed, Random.Range(-20f, 20f)));
        } else {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-ballStartSpeed, Random.Range(-20f, 20f)));
        }
    }

    private AudioSource audioSource;
    public AudioClip clickSound;

    void OnCollisionEnter2D(Collision2D colInfo) {
        if(colInfo.gameObject.tag == "Player") {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, GetComponent<Rigidbody2D>().velocity.y / 2 + colInfo.collider.GetComponent<Rigidbody2D>().velocity.y / 3);
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = clickSound;
            audioSource.pitch = Random.Range(0.8f, 1.2f);
            audioSource.Play();
        }
    }

}
