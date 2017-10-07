using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FodderAI : MonoBehaviour {

    public float speed = 1.0f;
    public float sinAmplitude = 1.0f;
    public float sinFrequency = 1.0f;
    private float hOffset = 0.0f;
    private float time;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

        // remove offset
        transform.position -= hOffset * transform.right;

        // moves forward
        transform.position += transform.forward * speed * Time.deltaTime;

        // adjust with sign wave
        hOffset = Mathf.Sin(time * sinFrequency) * sinAmplitude;

        transform.position += hOffset * transform.right;
        
    }
}
