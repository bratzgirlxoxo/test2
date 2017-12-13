using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	public float speed = 5;

	void Update () 
	{
		NormalMove();	
	}


	void NormalMove()
	{
		// right
		if (Input.GetAxisRaw("Horizontal") > 0)
		{
			transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
		// left
		if (Input.GetAxisRaw("Horizontal") < 0)
		{
			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}
		// up
		if (Input.GetAxisRaw("Vertical") > 0)
		{
			transform.Translate(Vector3.up * speed * Time.deltaTime);
		}
		// down
		if (Input.GetAxisRaw("Vertical") < 0)
		{
			transform.Translate(Vector3.down * speed * Time.deltaTime);
		}

	}
}
