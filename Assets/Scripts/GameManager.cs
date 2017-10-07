using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public bool gameOver = false;
    private void OnGUI() {
        if (gameOver) {
            GUILayout.Label("Game Over");
        }

    }
    private void Update() {
        if (gameOver) {
            if (Input.GetKeyDown(KeyCode.Return)) {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }

}
