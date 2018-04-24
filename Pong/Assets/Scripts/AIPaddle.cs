using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : MonoBehaviour {

    public Ball theBall;

    public float speed = 30;

    public float lerpTweak = 2f;

    private Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (theBall.transform.position.y > this.transform.position.y)
        {

        }
		
	}
}
