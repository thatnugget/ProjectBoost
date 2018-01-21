using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {

	private Rigidbody rigidBody;
	[SerializeField]
	private float turnSpeed = 100f;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		ProcessInput ();
	}


	private void ProcessInput(){



		if (Input.GetKey(KeyCode.Space)){
			Debug.Log ("thrusting");
			rigidBody.AddRelativeForce(new Vector3(0,55,0));
		}

		if (Input.GetKey(KeyCode.A)){
			transform.Rotate (Vector3.forward*Time.deltaTime*turnSpeed);
		}

		else if (Input.GetKey(KeyCode.D)){
			transform.Rotate (-Vector3.forward*Time.deltaTime*turnSpeed);
		}

	
	}
}
