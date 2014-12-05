using UnityEngine;
using System.Collections;

public class BasicSledMovment : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Forward force at all time
		rigidbody.AddForce (Vector3.forward * 10);

		//Input
		if (Input.KeyDown (KeyCode.UpArrow)) {

			rigidbody.AddForce (Vector3.left * 2);

				}
	
	}
}
