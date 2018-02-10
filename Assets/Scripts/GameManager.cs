using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {

	public GameObject enemyUno;
	public GameObject enemyDos;

	public GameObject genPointUno;
	public GameObject genPointDos;

	private bool genFlag;
	public float genWait;
	private float nextGen;

	// Use this for initialization
	void Start () {

		genFlag = true;

	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > nextGen) {

			EnGen ();

			nextGen = Time.time + genWait;

		}
		
	}

	void EnGen () {
		
		if (genFlag) {
			Instantiate (enemyUno, genPointUno.transform);
		}

		Instantiate (enemyDos, genPointDos.transform);

		genFlag = !genFlag;

	}

	void LoadNextLevel () {
		SceneManager.LoadScene ("Level2");
	
	}
		

}
