using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour {

    public GUISkin buttonsSkin;

    void OnGUI() {
        GUI.skin = buttonsSkin;

        if (GUI.Button(new Rect(Screen.width / 2 - 121 / 2, Screen.height / 2 + 53, 121, 53), "1 PLAYER")) {
            SceneManager.LoadScene("1Player");
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 121 / 2, Screen.height / 2 + 106, 121, 53), "2 PLAYERS")) {
            SceneManager.LoadScene("2Players");
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 121 / 2, Screen.height / 2 + 159, 121, 53), "EXIT")) {
            Application.Quit();
        }
    }
}
