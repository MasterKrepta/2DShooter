using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBackAndForth : MonoBehaviour {

    public float rot = 90;
   
    public float rotTime = 1.0f;

	// Use this for initialization
	void Start () {
        StartCoroutine("RotateForth");
	}
	
    IEnumerator RotateForth() {
        float t = 0;
        while(t < rotTime * 0.5f) {
            transform.RotateAround(transform.position, transform.up, Time.deltaTime / 
                                    (rotTime * 0.5f) * rot);
            t += Time.deltaTime;
            yield return null;
        }
        StartCoroutine("RotateBack");
    }
    IEnumerator RotateBack() {
        float t = 0;
        while (t < rotTime * 0.5f) {
            transform.RotateAround(transform.position, transform.up, -Time.deltaTime /
                                    (rotTime * 0.5f) * rot);
            t += Time.deltaTime;
            yield return null;
        }
        StartCoroutine("RotateForth");
    }

}
