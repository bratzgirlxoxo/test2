using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AI : MonoBehaviour {

    /*
    Accepts an array of transforms.
    All transforms must be at 90 degree angles to each other.
    Choose clockwise or counter clockwise movement.
    */

	// objects
	public Transform[] nodes;
	private Transform enemytran;
	private int counter = 0;
	public string moveDir;
	
	// public fields
	public float movementSpeed;

	private int nextNode;

	// Use this for initialization
	void Start ()
	{
		enemytran = transform;
	}
	
	// Update is called once per frame
	void Update () {
		MoveBetween(moveDir);
		
		
	}

	
	// moves the character between nodesr
	void MoveBetween(String direction)
	{
		if (direction.Equals("left"))
		{
			enemytran.Translate(-movementSpeed, 0, 0);
		} else if (direction.Equals("right"))
		{
			enemytran.Translate(movementSpeed, 0, 0);
		} else if (direction.Equals("up"))
		{
			enemytran.Translate(0, movementSpeed, 0);
		} else if (direction.Equals("down"))
		{
			enemytran.Translate(0, -movementSpeed, 0);
		} else if (direction.Equals("upright"))
		{
			enemytran.Translate(movementSpeed, movementSpeed, 0);
		} else if (direction.Equals("downright"))
		{
			enemytran.Translate(movementSpeed, -movementSpeed, 0);
		} else if (direction.Equals("upleft"))
		{
			enemytran.Translate(-movementSpeed, movementSpeed, 0);
		} else if (direction.Equals("downleft"))
		{
			enemytran.Translate(-movementSpeed, -movementSpeed, 0);
		}
	}


	// takes the current position and the next position from the array
	// compares the x and y values and returns a movement direction
	String CheckNext(Transform currPos, Transform nextPos)
	{
		String dir = "";

		// curr pos x and y
		float xc = currPos.position.x;
		float yc = currPos.position.y;

		// nextPos x and y
		float xn = nextPos.position.x;
		float yn = nextPos.position.y;

		// check the positions of the x and y values of currPos and nextPos
		
		// move upper right
		if (xc < xn && yc < yn)
		{
			dir = "upright";
		} else 
			// move lower right
		if (xc < xn && yc > yn)
		{
			dir = "downright";
		}
		else
			// move upper left
		if (xc > xn && yc < yn)
		{
			dir = "upleft";
		}
		else
			// move lower left
		if (xc > xn && yc > yn)
		{
			dir = "downleft";
		} else
		if (xc < xn)
		{
			dir = "right";
		} else 
		// N <------- C
		if (xc > xn)
		{
			dir = "left";
		}
		else
		// N
		// ^
		// C
		if (yc < yn)
		{
			dir = "up";
		}
		else
		// C
		// !
		// N
		if (yc > yn)
		{
			dir = "down";
		}

		return dir;
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		Transform node = other.gameObject.transform;

		if (nextNode < counter)
		{
			for (int i = 0; i < nodes.Length; i++)
			{
				if (nodes[i].Equals(node))
				{
					counter = i;
					break;
				}
			}
		}
		else
		{
			for (int i = counter; i < nodes.Length; i++)
			{
				if (nodes[i].Equals(node))
				{
					counter = i;
					break;
				}
			}
		}
		

		if (counter == nodes.Length - 1)
		{
			nextNode = 0;
		}
		else
		{
			nextNode = counter + 1;
		}

				

		moveDir = CheckNext(nodes[counter], nodes[nextNode]);
		print("counter: " + counter);
		print("next: " + nextNode);
		print("movedir: " + moveDir);
	}
}
