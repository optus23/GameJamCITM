using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGame3 : MonoBehaviour {

    private GameObject[] balls;
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset.Set(0.0f, 0.0f, 0.0f);
        balls = GameObject.FindGameObjectsWithTag("Ball");
    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.0f));
    }

    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.0f)) + offset;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.tag == "Ball")
        {
            
        }
    }
}
