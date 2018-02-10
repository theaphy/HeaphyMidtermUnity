using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	private GameObject target;
	public float speed;

	// Use this for initialization
	void Start () {

		target = GameObject.FindGameObjectWithTag ("Player");
		
	}
	
	// Update is called once per frame
	void Update () {

		float step = speed * Time.deltaTime;

		Vector3 newPos =  Vector3.MoveTowards (
				transform.position, 
				target.transform.position, 
				step
			); 
			
		transform.position = new Vector3 (newPos.x, newPos.y, transform.position.z);

	}
		
}
