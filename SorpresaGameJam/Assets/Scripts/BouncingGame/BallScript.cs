using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    private Rigidbody2D mRigidbody2D;
    private float speed = 1.0f;

    void Start()
    {
        mRigidbody2D = this.GetComponent<Rigidbody2D>();
        mRigidbody2D.velocity = new Vector2(5.0f, 0);
        mRigidbody2D.velocity = Quaternion.AngleAxis( Random.Range(0, 360), Vector3.forward) * mRigidbody2D.velocity;
    }

    private void Update()
    {
        mRigidbody2D.velocity = mRigidbody2D.velocity.normalized * speed;
        speed += 0.3F * Time.deltaTime;
    }


}
