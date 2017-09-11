using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBoiScript : MonoBehaviour {
	[SerializeField]
	private bool direction;
    bool readyToPlay;
	// Use this for initialization
	void Start () {
		readyToPlay = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKey)
            readyToPlay = true;
		if(readyToPlay) {
			if (!direction)
		    	transform.position += new Vector3(Time.deltaTime * .5f,0,0);
		    else
		    	transform.position += new Vector3(Time.deltaTime * -.5f,0,0);
		}
		transform.Rotate(0,0,Time.deltaTime * -314f);
	}

	void OnCollisionEnter2D(Collision2D coll) {
        direction = !direction;
        print("yep");

    }
}
