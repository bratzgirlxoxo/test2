using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{


	private GameObject player;
	private Transform tran;
	
	Animator ani_this;

	void Start () 
	{
		ani_this = gameObject.GetComponent<Animator> ();
	}

	void Update () 
	{
		NormalMove();	
	}


	void NormalMove()
	{
		// right
		if (Input.GetAxisRaw("Horizontal") > 0)
		{
			ani_this.SetBool("ifRight", true);
			ani_this.SetBool("ifLeft", false);
			ani_this.SetBool("ifDown", false);
			ani_this.SetBool("ifUp", false);
		}
		// left
		if (Input.GetAxisRaw("Horizontal") < 0)
		{
			ani_this.SetBool("ifRight", false);
			ani_this.SetBool("ifLeft", true);
			ani_this.SetBool("ifDown", false);
			ani_this.SetBool("ifUp", false);		
		}
		// up
		if (Input.GetAxisRaw("Vertical") > 0)
		{
			ani_this.SetBool("ifRight", false);
			ani_this.SetBool("ifLeft", false);
			ani_this.SetBool("ifDown", false);
			ani_this.SetBool("ifUp", true);		
		}
		// down
		if (Input.GetAxisRaw("Vertical") < 0)
		{
			ani_this.SetBool("ifRight", false);
			ani_this.SetBool("ifLeft", false);
			ani_this.SetBool("ifDown", true);
			ani_this.SetBool("ifUp", false);		
		}
		if (Input.GetAxisRaw("Vertical") == 0 && Input.GetAxisRaw("Horizontal") == 0)
		{
			ani_this.SetBool("ifRight", false);
			ani_this.SetBool("ifLeft", false);
			ani_this.SetBool("ifDown", false);
			ani_this.SetBool("ifUp", false);
		}
	}
}
