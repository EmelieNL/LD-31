using UnityEngine;
using System.Collections;

public class BasicSledMovment : MonoBehaviour {

	public int forwardSpeed = 10;
	public int maxX = 4;
	public int minX = -4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x <= minX){
			//transform.position = Vector3(minX, transform.position.y, transform.position.z);
		}

		if(transform.position.x >= maxX){
			//transform.position = Vector3(maxX,transform.position.y, transform.position.z);
		}
		//Forward force at all time
		rigidbody.AddForce (Vector3.forward * forwardSpeed);

		//Input
		if (Input.GetKey(KeyCode.UpArrow) ){
			Debug.Log(transform.position);
			//transform.position.x = minX;
			Debug.Log("Up");

			rigidbody.AddForce (Vector3.left * 20);

		} else if (Input.GetKey(KeyCode.DownArrow) ){
			Debug.Log("Down");
			
			rigidbody.AddForce (Vector3.right * 20);
			
		}
	
	}
}
