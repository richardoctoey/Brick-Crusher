using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
	private Paddle paddle;
	
	private Vector3 paddleToBallVector;
	
	private bool hasStarted = false;
	
	private Rigidbody2D rigidBody;
	// Use this for initialization
	void Start ()
	{
		paddle = GameObject.FindObjectOfType<Paddle>();
		rigidBody = GetComponent<Rigidbody2D>();
		
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!hasStarted) {
			//Lock the Ball Relative to Paddle
			this.transform.position = paddle.transform.position + paddleToBallVector;
		
			//Wait for mouse press for game start/launch.
			if (Input.GetMouseButtonDown (0)) {
				print ("Mouse Clicked, launch ball");
				hasStarted = true;
				this.rigidBody.velocity = new Vector2 (2f, 10f);
			}
		}
	}
}
