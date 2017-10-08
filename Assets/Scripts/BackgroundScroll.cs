using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour {

    public float vScrollSpeed = 1.0f;
    public float hScrollMultiplier = 1.0f;
    Renderer rend;
    Transform player;
	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }
	
	// Update is called once per frame
	void Update () {

        if (player != null) { // of player is dead
            Vector2 newTextureOffset = rend.material.mainTextureOffset;
            newTextureOffset.x = player.position.x * hScrollMultiplier;
            newTextureOffset.y += vScrollSpeed * Time.deltaTime;
            rend.material.mainTextureOffset = newTextureOffset;
        }
        else {
            
            //player = GameObject.FindGameObjectWithTag("Player").transform;
        }

    }
}
