using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float  horizontalSpeed = 2.0F;
	public float  verticalSpeed = 2.0F;
	float speedCurrent =0; 
	float maxSpeed = 25;
	float acceleration = 15;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float h = horizontalSpeed * Input.GetAxis("Horizontal");
		float v  = verticalSpeed * Input.GetAxis("Vertical");
		transform.Rotate(v, h, 0);

		bool pressedSpace = Input.GetKey(KeyCode.Space);
		if(pressedSpace){
			speedCurrent = speedCurrent + acceleration * Time.deltaTime;

		}
		else{
			speedCurrent = speedCurrent - acceleration * Time.deltaTime;

		}
		speedCurrent = Mathf.Clamp(speedCurrent, 0, maxSpeed);
		transform.position = transform.position + transform.forward * speedCurrent * Time.deltaTime;
	}
}
