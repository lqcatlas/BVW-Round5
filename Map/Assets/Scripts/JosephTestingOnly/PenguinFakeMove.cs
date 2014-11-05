using UnityEngine;
using System.Collections;

public class PenguinFakeMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.W)) {
			rigidbody.AddForce(new Vector3(100, 0, 0));		
		}
		else if (Input.GetKeyDown (KeyCode.S)) {
			rigidbody.AddForce(new Vector3(-100, 0, 0));
		}
		else if (Input.GetKeyDown (KeyCode.A)) {
			rigidbody.AddForce(new Vector3(0, 0, 100));
		}
		else if (Input.GetKeyDown (KeyCode.D)) {
			rigidbody.AddForce(new Vector3(0, 0, -100));
		}
	}
}
