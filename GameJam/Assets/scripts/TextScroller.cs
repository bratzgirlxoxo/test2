using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScroller : MonoBehaviour
{

	public float text_x;
	public float text_y;
	public float text_z;

	public float scrollSpeed;
	public float stopSpot;
	
	// Use this for initialization
	void Start ()
	{
		text_x = gameObject.transform.position.x;
		text_y = gameObject.transform.position.y;
		text_z = gameObject.transform.position.z;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (text_y <= stopSpot)
		{
			text_y += scrollSpeed;
		}
		
		gameObject.transform.position = new Vector3(text_x,text_y,text_z);
	}
}
