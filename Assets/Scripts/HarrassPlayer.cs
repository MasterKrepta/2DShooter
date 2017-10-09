using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarrassPlayer : MonoBehaviour {

    public float maxDistance = 1.0f;
    public float moveTime = 1.0f;
    public float waitTime = 1.0f;
    Transform player;
    public bool remainNearInitPos = false;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine("RandomMove");
	}
	
    IEnumerator RandomMove() {
        if (player != null) {
            float t = 0;
            float currentMoveTime = moveTime;
            Vector3 initPos = transform.position;
            Vector3 moveVector = Random.insideUnitCircle * maxDistance;
            Vector3 endPos = player.position + moveVector;

            if (currentMoveTime < 0) {
                currentMoveTime = float.Epsilon;
                Debug.Log("WARNING move time set to 0 or less");
            }

            while (t < currentMoveTime) {
                transform.position = Vector3.Lerp(initPos, endPos, t / currentMoveTime);
                t += Time.deltaTime;
                yield return null;
            }
            yield return new WaitForSeconds(waitTime);

        } else {
                player = GameObject.FindGameObjectWithTag("Player").transform;
                yield return new WaitForSeconds(waitTime);
        }
        
        StartCoroutine("RandomMove");
    }
}
