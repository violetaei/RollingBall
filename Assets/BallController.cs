using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public int speed;
    Rigidbody ballRigidBody;

	// Use this for initialization
	void Start () {
        Debug.Log("Hello human");
        ballRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Input.GetAxis("Horizontal"));

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);

        // This is my comment adding the directin as a force to the rigidbody

        ballRigidBody.AddForce(direction);
	}
}
