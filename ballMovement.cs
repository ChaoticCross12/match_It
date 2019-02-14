using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour {

	private Rigidbody2D rb;
	public float ballSpeed;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce (transform.up * ballSpeed);
	}

	void Update(){
		Vector2 v = GetComponent<Rigidbody2D>().velocity;
		v = v.normalized;
		v *= ballSpeed;
		GetComponent<Rigidbody2D>().velocity = v;

	}
}
	

