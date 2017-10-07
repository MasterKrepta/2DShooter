using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverOnDestroy : MonoBehaviour {

    GameManager gm;

    private void Awake() {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
      
    }

    private void OnDestroy() {
        
            gm.gameOver = true;
    }
}
