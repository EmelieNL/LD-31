using UnityEngine;
using System.Collections;

public class BackgroundMover : MonoBehaviour {

	Rigidbody player;
	
	void Start(){

		//Get player obj
		GameObject player_go = GameObject.FindGameObjectWithTag ("Player");
		
		if (player_go == null) {
			
			Debug.LogError("Could not find the game object with tag 'player'.");
			return;
		} 
		
		player = player_go.rigidbody;
		
	}
	
	void FixedUpdate () {

		//move the bg forward
		float vel = player.velocity.z * 0.9f;
		transform.position = transform.position + Vector3.forward * vel * Time.deltaTime;
	}
}
