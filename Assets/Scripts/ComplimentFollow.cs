using UnityEngine;
using System.Collections;

public class ComplimentFollow : MonoBehaviour {

	public Transform Player;
	public float moveSpeed = 4;
	public float minDist = 5;


	void Update () 
	{
		transform.LookAt(Player);

		if (Vector3.Distance (transform.position, Player.position) >= minDist) {

			transform.position += transform.forward * moveSpeed * Time.deltaTime;
		}
	}
	
}
