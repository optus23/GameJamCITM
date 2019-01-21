using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayer : MonoBehaviour {

    bool can_jump = true;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown("up") && can_jump)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 270f));
            can_jump = false;
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "Ground")
        {
            can_jump = true;
            Debug.Log("Hi");
        }
    }
}
