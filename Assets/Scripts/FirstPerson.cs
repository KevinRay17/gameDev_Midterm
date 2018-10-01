using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
	public float moveSpeed = 10.0f;

	private float lookSpeed = 500.0f;

	private Vector3 inputVector;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		float mouseX = Input.GetAxis(("Mouse X")) *lookSpeed*Time.deltaTime;
		float mouseY = Input.GetAxis(("Mouse Y"))*lookSpeed*Time.deltaTime;
		transform.Rotate(0,mouseX,0);
		Camera.main.transform.Rotate(-mouseY,0,0);
		Camera.main.transform.localEulerAngles -= new Vector3(0,0,Camera.main.transform.localEulerAngles.z);

		float vertical = Input.GetAxis(("Vertical"));
		float horizontal = Input.GetAxis(("Horizontal"));

		inputVector = transform.forward * vertical * moveSpeed;
		inputVector += transform.right * horizontal * moveSpeed;

	}

	void FixedUpdate()
	{
		GetComponent<Rigidbody>().velocity = inputVector;
	}
}
