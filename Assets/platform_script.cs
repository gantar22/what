using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_script : MonoBehaviour {
	float timeStart;
	// Use this for initialization
	void Start () {
		timeStart = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Mathf.Sin(Time.time - timeStart) + 1.4f,transform.position.y,0);
	}
}
