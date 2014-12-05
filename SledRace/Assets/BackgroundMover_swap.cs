using UnityEngine;
using System.Collections;

public class BackgroundMover_swap : MonoBehaviour {

	int numBGPanels = 4;
	
	void OnTriggerEnter(Collider collider){
				Debug.Log ("Triggered collide: " + collider.name);
		
				//float withOfBGObject = ((BoxCollider)collider).size.z;
			float withOfBGObject = 20;
		
				Vector3 pos = collider.transform.position;

				pos.z += withOfBGObject * numBGPanels - withOfBGObject / 2;
		
				collider.transform.position = pos;
		}
	
}
