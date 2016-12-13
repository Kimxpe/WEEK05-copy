using UnityEngine;
using System.Collections;

public class backAndForth : MonoBehaviour {


	public Transform pointA;
	public Transform pointB;

	public float percent = 0;

	public float numberOfSeconds = 3;
	public float direction = -1;

	void Start () {
	}

	void Update () {
		// set position for the cube as an interpolation
		transform.position = Vector3.Lerp(pointA.position, pointB.position, percent);
		transform.rotation = Quaternion.Slerp (pointA.rotation, pointB.rotation, percent); //for rotating an angle
		//for lerping a float: Mathf.Lerp


		percent += Time.deltaTime / numberOfSeconds * direction; 
		if (percent > 1) {
			direction = -1;
		}
		if (percent < 0) {
			direction = 1;
		}

		GetComponent<Renderer> ().material.color = Color.Lerp (Color.gray, Color.gray, percent);
	}
}
