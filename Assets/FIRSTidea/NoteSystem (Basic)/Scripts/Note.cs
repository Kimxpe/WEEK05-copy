using UnityEngine;
using System.Collections;

public class Note : MonoBehaviour {
	
	//The Text Of The Note
	public string Text = "Insert Your Text Here!";
	
	void Start () {
	
		//AutoSet the Name
		transform.name = "Note";
		
		//If there is no collider on the note add one
		if (GetComponent<Collider>() == null) {
			
			Debug.LogError ("No Collider On Note " + name + ". Add A Collider!");
			
		}
		
	}
		
}
