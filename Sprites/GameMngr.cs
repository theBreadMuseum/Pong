﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMngr : MonoBehaviour {

    public static int player1Score = 0;
    public static int player2Score = 0;

    public GUISkin scoreSkin;

    public static void Score(string wallName) {
        if (wallName == "rightWall") {
            player1Score += 1;
        } else {
            player2Score += 1;
        }
    }

    void OnGUI() {
        GUI.skin = scoreSkin;
        GUI.Label(new Rect(Screen.width / 2 - 150, 20, 100, 100), "" + player1Score);
        GUI.Label(new Rect(Screen.width / 2 + 150, 20, 100, 100), "" + player2Score);
    }

}
