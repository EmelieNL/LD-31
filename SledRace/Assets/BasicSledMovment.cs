using UnityEngine;
using System.Collections;

public class BasicSledMovment : MonoBehaviour {

	public int forwardSpeed = 10;
	public int maxX = 18;
	public int minX = -18;
	public float topSpeed = 15;
	public int jumpSpeed = 40;
	// Use this for initialization
	void Start () {
		rigidbody.freezeRotation = true;
	}
	
	// Update is called once per frame
	void Update () {

		//Forward force at all time
		rigidbody.AddForce (Vector3.forward * forwardSpeed);

		//Adjust movment according to player input
		Movment();

		//Debug.Log("Speed: " + rigidbody.velocity.z);

	
	}

	//Method to adjust player pos
	void Movment() { 

		//Limit max speed
		Vector3 velocity = rigidbody.velocity;

		if (velocity.z > topSpeed) {
				velocity.z = topSpeed;
				rigidbody.velocity = velocity;
			}

		//Read current player input movment
		var vertical = Input.GetAxis ("Vertical"); 

		//Get current position
		Vector3 pos = transform.position;

		//Set x pos with bounds
		pos.x = Mathf.Clamp(pos.x - vertical, minX, maxX);


		//update pos
		transform.position = pos;


		//Jumping
		if(Input.GetButtonDown("Jump")){
			Debug.Log("Jumping!");
			rigidbody.AddForce(Vector3.up * jumpSpeed);
		}

		
	} 
}
