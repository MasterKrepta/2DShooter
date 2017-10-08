using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekingMissle : MonoBehaviour {

    Rigidbody rb;
    public float initVelocity = 10.0f;
    public float missleAcceleration = 10.0f;
    public float maxVelocity = 10.0f;
    
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce((transform.forward * initVelocity), ForceMode.VelocityChange);
        rb.AddForce(missleAcceleration * transform.forward * Time.deltaTime, ForceMode.Acceleration);
        if(rb.velocity.magnitude > maxVelocity) { // this should probobly be clamped instead!
            rb.velocity = rb.velocity.normalized * maxVelocity;
        }
	}
}
