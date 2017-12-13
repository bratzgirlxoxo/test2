using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinController : MonoBehaviour {

	private void OnCollisionEnter2D(Collider2D other)
	{
		if(other.CompareTag("finish"))
		{
			SceneManager.LoadScene("WinScene");
		}

	}

}
