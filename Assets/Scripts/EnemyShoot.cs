using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {

    public Transform bullet;
    public float shotDelay = 0.2f;
    private bool readyShoot = true;
    // Use this for initialization
    void Start () {
        Invoke("Shoot", shotDelay);
	}
	

    void Shoot() {
        Instantiate(bullet, transform.position, transform.rotation);
        Invoke("Shoot", shotDelay);
    }
}
