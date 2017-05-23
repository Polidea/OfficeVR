using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVrScript : MonoBehaviour {
	private bool walking = true;
	private Vector3 spawnPoint;
	// Use this for initialization
	void Start () {
		spawnPoint = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position= transform.position + new Vector3(0.1f,0f, 0.1f);		

//
//		if (transform.position.y < -10f) {
//			transform.position = spawnPoint;
//		}
//
//		Ray ray = Camera.main.ViewportPointToRay (new Vector3 (.5f, .5f, 0));
	
	}
}
