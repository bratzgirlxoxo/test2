using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

	public Camera currCam;
	public Camera failCam;
	
	private void OnCollisionEnter2D(Collision2D other)
	{
		GameObject thing = other.gameObject;

		if (thing.CompareTag("Sensor"))
		{
			failCam.enabled = true;
			currCam.enabled = false;
		} else if (thing.CompareTag("Enemy"))
		{
			failCam.enabled = true;
			currCam.enabled = false;
		}
	}
}
