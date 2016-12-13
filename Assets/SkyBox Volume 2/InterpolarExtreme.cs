using UnityEngine;
using System.Collections;

public class InterpolarExtreme : MonoBehaviour {

	public Transform pointA;
	public Transform pointB;

	public float percent = 0;

	public float numberOfSeconds;

	void Start () {
		//		pointA = GameObject.Find("pointA").transform; //this line is optional. its so that you dont have to drag and drop variable like public makes you do.
	}

	void Update () {
		// set position for the cube as an interpolation
		transform.position = Vector3.Lerp(pointA.position,pointB.position,percent);

		//Time.deltaTime is the amount of change between this frame and the last one
		percent = percent + Time.deltaTime / numberOfSeconds; 
		if (percent > 1) {
			percent = 0;
		
		}

		GetComponent<Renderer> ().material.color = Color.Lerp (Color.red, Color.blue, percent); // to change color as well
	}
}
