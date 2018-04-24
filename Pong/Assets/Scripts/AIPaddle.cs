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

        // TODO: move Lerp in if/else to it's own function to DRY code.
        // if the ball's y position is above the paddle:
        if (theBall.transform.position.y > this.transform.position.y)
        {
            // Set paddle vector to go up
            Vector2 dir = new Vector2(0, 1);

            // per Lerp (?what is Lerp?) to smooth out movement
            rigidBody.velocity = Vector2.Lerp(rigidBody.velocity,
                dir * speed,
                lerpTweak * Time.deltaTime);
        }
        // if the ball's y position is below the paddle:
        else if (theBall.transform.position.y < this.transform.position.y)
        {
            // Set paddle vector to go down
            Vector2 dir = new Vector2(0, -1);

            // per Lerp (?what is Lerp?) to smooth out movement
            rigidBody.velocity = Vector2.Lerp(rigidBody.velocity,
                dir * speed,
                lerpTweak * Time.deltaTime);
        }
        // if ball is neither up nor down relative to the paddle, then it must be vertically even so stop moving the paddle.
        else {
            Vector2 dir = new Vector2(0,0).normalized;
            rigidBody.velocity = Vector2.Lerp(rigidBody.velocity,
                dir * speed,
                lerpTweak * Time.deltaTime);
        }

    }
}
