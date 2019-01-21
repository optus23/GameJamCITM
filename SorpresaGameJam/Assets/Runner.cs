using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour {

    public float speed = 2.0f;
    public float jump_force = 5.0f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position += transform.up* jump_force*Time.deltaTime;
        }
	}
}
