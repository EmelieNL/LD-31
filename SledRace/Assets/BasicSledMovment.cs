using UnityEngine;
using System.Collections;

public class BasicSledMovment : MonoBehaviour {

	public int forwardSpeed = 10;
	public int maxX = 18;
	public int minX = -18;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Forward force at all time
		rigidbody.AddForce (Vector3.forward * forwardSpeed);

		//Adjust movment according to player input
		Movment();

	
	}

	//Method to adjust player pos
	void Movment() { 

		//Read current player input movment
		var vertical = Input.GetAxis ("Vertical"); 

		//Get current position
		Vector3 pos = transform.position;

		//Set x pos with bounds
		pos.x = Mathf.Clamp(pos.x - vertical, minX, maxX);

		//update pos
		transform.position = pos;
		
	} 
}
