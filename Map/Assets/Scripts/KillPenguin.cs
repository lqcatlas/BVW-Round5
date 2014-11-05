using UnityEngine;
using System.Collections;

public class KillPenguin : MonoBehaviour {

	//public GameManager game
	public GameObject[] penguins;
	public GameObject[] rebirthPoints;

	// Use this for initialization
	void Start () {
//		penguins = new GameObject [game.penguins.Length];
//		for(int i=0; i<penguins.Length; i++){
//			penguins[i] = game.GetPenguin(i);
//		}
//		rebirthPoints = new GameObject [game.rebirthPoints.Length];
//		for(int i=0; i<rebirthPoints.Length; i++){
//			rebirthPoints[i] = game.GetRebirthPoints(i);
//		}
	}

	void OnTriggerEnter(Collider other){
		//Find Which Penguin
		for (int i=0; i<penguins.Length; i++) {
			if (other.name.Contains (penguins[i].name)) {
					SendPenguinBackHome (i);
			}
		}
	}

	void OnCollisionEnter(Collision other){

	}

	// Update is called once per frame
	void Update () {
	
	}

	void SendPenguinBackHome(int i){
		//Send specific penguin back to its spawning point
		Debug.Log("Send Penguin " + i + " Back!!");
		penguins [i].transform.position = rebirthPoints [i].transform.position;
		penguins [i].rigidbody.velocity = new Vector3 (0, 0, 0);
	}
}
