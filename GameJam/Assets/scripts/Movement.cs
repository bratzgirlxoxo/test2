using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	// public fields
	public float strength;
	
	// private objects
	private GameObject player;
	private Transform tran;
	
	// Use this for initialization
	void Start ()
	{
		player = transform.gameObject;
		tran = player.transform;
	}
	
	// Update is called once per frame
	void Update () {
		NormalMove();
		
	}


	void NormalMove()
	{
		// right
		if (Input.GetAxisRaw("Horizontal") > 0)
		{
			tran.Translate(strength, 0, 0);
		}
		// left
		if (Input.GetAxisRaw("Horizontal") < 0)
		{
			tran.Translate(-strength, 0, 0);
		}
		// up
		if (Input.GetAxisRaw("Vertical") > 0)
		{
			tran.Translate(0, strength, 0);
		}
		// down
		if (Input.GetAxisRaw("Vertical") < 0)
		{
			tran.Translate(0, -strength, 0);
		}
	}
}
