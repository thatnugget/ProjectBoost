using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ProcessInput ();
	}


	private void ProcessInput(){
		
		if (Input.GetKey(KeyCode.Space)){
			Debug.Log ("thrusting");
		}

		if (Input.GetKey(KeyCode.A)){
			Debug.Log ("rotate left");
		}

		else if (Input.GetKey(KeyCode.D)){
			Debug.Log ("rotate right");
		}

	
	}
}
