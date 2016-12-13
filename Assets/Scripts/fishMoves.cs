using UnityEngine;
using System.Collections;

public class fishMoves : MonoBehaviour {

	// declare state constants
	private const int WAITING_ON_LURE = 0;  // const is optional but tells computer that value won't change
	private const int FOLLOWING_LURE = 1;	// written in caps and underscore to declare that its a state. stylistic but often used and easy to read
	private const int CAUGHT_ON_LURE = 2;


	public float minDist = 5;

	// state variable to determine behavior
	public int state = WAITING_ON_LURE;

	private float fishSpeed = 13;

	private Transform lurePosition;

	void Update () {							//double "=" is for conditionals, single "=" assigns value
		if (state == WAITING_ON_LURE) {   		// default state. will swim around
		
		} else if (state == FOLLOWING_LURE &&  Vector3.Distance (transform.position, lurePosition.position) >= minDist) {   // a lure is within range, swim towards it
			transform.LookAt( lurePosition );
			transform.position += transform.forward * Time.deltaTime * fishSpeed;
		
		} else if (state == CAUGHT_ON_LURE) {   // the fish caught the lure, and is parented to it.
			transform.position = lurePosition.position;
		}


	}

	void OnTriggerEnter(Collider otherCollider) {
		state = FOLLOWING_LURE;					// lure comes close enough to the fish so it starts following
		lurePosition = otherCollider.transform;
	}

	void OnTriggerExit() {
		state = WAITING_ON_LURE; 
	}

	void OnCollisionEnter(	Collision collisionData ) {					// Collision sees if fish catches the lure
		state = CAUGHT_ON_LURE;
		lurePosition = collisionData.transform;
	}
}
