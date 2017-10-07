using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibOnTrigger : MonoBehaviour {

    public Transform explosion;
	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter(Collider other) {
 
        Debug.Log("Hit");
        if (explosion != null) {
            
            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
