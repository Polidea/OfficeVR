using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class VRLookWalk : MonoBehaviour {

	public Transform vrCamera;

	public float toggleAngle = 30f;

	public float speed = 3f;

	public bool moveForward;


	private CharacterController cc;

	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();
		//CrossPlatformInputManager.SwitchActiveInputMethod(CrossPlatformInputManager.ActiveInputMethod.Hardware);
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 forward2 = vrCamera.TransformDirection (Vector3.forward);
		float mutiSpeed = speed;
#if UNITY_HAS_GOOGLEVR && (UNITY_ANDROID || UNITY_EDITOR)
		mutiSpeed =  GvrController.ClickButton ? speed : 0f;
#endif
		cc.SimpleMove (forward2 * mutiSpeed);
		//Debug.Log("Unity# : Button State  " +GvrController.ClickButton );

	}
}
