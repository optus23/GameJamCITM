using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayer : MonoBehaviour {

    bool can_jump = true;
    public float jump_amount = 250f;
    public Sprite jumping;
    public Sprite idle;


	void Update ()
    {
		if(Input.GetKeyDown("up") && can_jump)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump_amount));
            can_jump = false;
        }
        if(!can_jump)
        {
            GetComponent<SpriteRenderer>().sprite = jumping;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = idle;
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
