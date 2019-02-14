using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour {

	private Rigidbody2D rb;

	public float rotationSpeed;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate () {

		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.forward * -90 * Time.deltaTime * 2);
			}
		else if (Input.GetKey (KeyCode.D)){
			transform.Rotate (Vector3.back * -180 * Time.deltaTime);
			}
		}

}
