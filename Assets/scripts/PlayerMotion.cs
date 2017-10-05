using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour {

    public float speed;
    Transform tr;

	// Use this for initialization
	void Start () {
        tr = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		tr.position += Vector3.Lerp(tr.position, new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")), speed);
	}
}
