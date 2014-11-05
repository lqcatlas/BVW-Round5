using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	public Vector3 moveDirection = Vector3.zero;
	public bool isGrounded = false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void moveToward(Vector3 dest)
	{
		this.rigidbody.AddForce(dest*speed*2.5f);
		//moveDirection = dest;
	}

	public void stop()
	{
		moveDirection = Vector3.zero;
	}

}
