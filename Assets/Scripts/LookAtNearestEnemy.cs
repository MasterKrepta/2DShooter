using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtNearestEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float nearestDistance = Mathf.Infinity;
        Transform nearestEnemy = null;
		foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Enemies")) {
            float distance = (transform.position - obj.transform.position).sqrMagnitude;
            if ( distance < nearestDistance) {
                nearestDistance = distance;
                nearestEnemy = obj.transform;
            }
        }
        if(nearestEnemy != null) {
            transform.rotation = Quaternion.LookRotation(nearestEnemy.transform.position - transform.position, Vector3.back);
        }
        
	}
}
