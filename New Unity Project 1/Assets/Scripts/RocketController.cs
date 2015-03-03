using UnityEngine;
using System.Collections;

public class RocketController : MonoBehaviour {

	public float flySpeed = 5;


	void Start () 
	{
	
	}
	

	void Update () 
	{
		if (Input.GetKey (KeyCode.Space))
		{
			rigidbody2D.AddForce(Vector3.up * flySpeed);
		}
	}
}
