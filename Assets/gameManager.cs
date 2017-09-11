using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour {
    bool readyToPlay;
	// Use this for initialization
	void Start () {
		readyToPlay = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.anyKey)
            readyToPlay = true;
	}
}
