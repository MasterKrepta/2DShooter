using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public Transform bullet;
    public float shotDelay = 0.2f;
    private bool readyShoot = true;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1") && readyShoot) {
            readyShoot = false;
            Instantiate(bullet, transform.position, transform.rotation);
            Invoke("ResetReadyToShoot", shotDelay);
        }
	}
    private void ResetReadyToShoot() {
        readyShoot = true;
    }
}
