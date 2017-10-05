using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour {

	public float speed;
	public float randomSpeedMin;
	public float randomSpeedMax;
	Rigidbody rb;

	// Use this for initialization
	void Start (){
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		Random.Range()
		
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			rb.AddForce(0, speed, 0);
		}
	}
}
