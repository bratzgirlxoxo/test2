using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour {


	public void Update()
	{	
		// Restart
		if (Input.GetKeyDown(KeyCode.R))
		{
			SceneManager.LoadScene("Intro");
		}
	}
}