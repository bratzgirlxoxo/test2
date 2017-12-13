using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doSomething : MonoBehaviour {

	float timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		GetComponent<TextMesh> ().text = "MR. Time " + Mathf.Round(timer);
		
	}
}
