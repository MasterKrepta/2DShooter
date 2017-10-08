using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    public int initHealth = 10;
    private int currentHealth;
    public Transform hitEffect;
    public Transform DeathEffect;
    // Use this for initialization
    void Start () {
        currentHealth = initHealth;
	}

    private void OnTriggerEnter(Collider col) {
        
        currentHealth--;
        Instantiate(hitEffect, col.transform.position, Quaternion.identity);
        if (currentHealth <= 0) {
            Instantiate(DeathEffect, col.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}

