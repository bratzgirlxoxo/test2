using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meds : MonoBehaviour
{
	public string[] medications;
	public string thisMedication;
	public int randomIndex;

	private void Start()
	{
		randomIndex = Random.Range(0, medications.Length);
		thisMedication = medications[randomIndex];
	}

	private void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			print(thisMedication);
		}
	}
}
