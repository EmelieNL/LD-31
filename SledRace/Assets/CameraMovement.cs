using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	Transform player;
	
	public float offsetz = 0;
	
	// Use this for initialization
	void Start () {
		
		GameObject player_go = GameObject.FindGameObjectWithTag ("Player");
		
		if (player_go == null) {
			Debug.LogError("Could not find the object with tag 'Player'");	
			return;
		}
		
		player = player_go.transform;
		
		//offsetz = transform.position.x - player.position.x;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (player != null) {
			Vector3 pos = transform.position;
			pos.z = player.position.z + offsetz;
			transform.position = pos;
			
		}
		
	}
}
