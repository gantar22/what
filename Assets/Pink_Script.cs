using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pink_Script : MonoBehaviour {
    
    float jumpDeadTime;
    float jumpHeight;
	// Use this for initialization
	void Start () {
		float jumpDeadTime = 0;
		jumpHeight = 4;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 velocity = new Vector3 (Input.GetAxis("Horizontal_P"),0f,0f);
		transform.Translate(velocity * Time.deltaTime);
		if(Physics2D.Raycast(transform.position + new Vector3(0,-.11f,0),Vector3.down,.07f,~(1<<8)).collider != null && Input.GetButton("Jump_P")
			&& jumpDeadTime == 0)
		{
			GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpHeight,ForceMode2D.Impulse);
			jumpDeadTime += Time.deltaTime;
			
		}
		if (jumpDeadTime > 0)
		    jumpDeadTime += Time.deltaTime;
		    if (jumpDeadTime > .250)
		    	jumpDeadTime = 0;
	    if (transform.position.y < -5f) 
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (Mathf.Abs(transform.rotation.z) > .5f)
           transform.rotation = Quaternion.Euler(0, 0, 0);
	}
	void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "Enemy")
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
