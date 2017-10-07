using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour {

    public Transform objectToSpawn;
    public float spawnDelay = 1.0f;
	// Use this for initialization
	void Start () {
        Invoke("Spawn", spawnDelay);
    }
	
	// Update is called once per frame
	void Spawn () {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
        Invoke("Spawn", spawnDelay);
    }
}
