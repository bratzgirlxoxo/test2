using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
	

	// public fields
	public float frequency;

	
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3 (0, 0, -frequency));
	}
}
