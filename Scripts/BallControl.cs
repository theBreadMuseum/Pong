using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    public int ballStartSpeed = 90;

    void Start() {
        StartCoroutine(BallStartTimer());
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

    void OnCollisionEnter2D(Collision2D colInfo) {
        if(colInfo.gameObject.tag == "Player") {
            Debug.Log("AAAAAAAAAAA");
        }
    }

}
