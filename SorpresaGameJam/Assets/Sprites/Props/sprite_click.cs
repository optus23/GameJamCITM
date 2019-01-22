using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprite_click : MonoBehaviour {

    public Sprite closed;
    public Sprite open;
    private bool is_open = false;
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        is_open = !is_open;
        SetSprite();
    }
    
    void SetSprite()
    {
        if(is_open)
        {
            GetComponent<SpriteRenderer>().sprite = open;
;       }
        else
        {
            GetComponent<SpriteRenderer>().sprite = closed;
        }
    }
}
