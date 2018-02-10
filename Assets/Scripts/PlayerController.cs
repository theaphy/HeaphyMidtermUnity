using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float jumpForce;

	private Rigidbody baller;

	public GameObject gameOver;
	public GameObject youWon;

	// Use this for initialization
	void Start () {

		baller = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal * -1, 0.0f, moveVertical * -1);

		baller.AddForce(movement * speed);


		if (Input.GetKeyDown(KeyCode.Space)) { 
			
			baller.AddForce (new Vector3 (moveHorizontal * -1, jumpForce, moveVertical * -1));

		}

	}

	void OnCollisionEnter (Collision col) {

		if(col.gameObject.name.Contains("Enemy") || col.gameObject.name == ("ToxicPool")) {

			gameOver.SetActive (true);

		}

		if (col.gameObject.name == ("PillarTrigger")) {
			Debug.Log (this);
			youWon.SetActive (true);
		
		}
	}
}
