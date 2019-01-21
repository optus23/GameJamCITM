using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scip : MonoBehaviour {

    public GameObject board;

    public float MoveSpeed = 40.0F;

    private Rigidbody2D mRigidbody2D;

    private float mMovementX = 0;
    private float mMovementY = 0;

    void Start()
    {
        mRigidbody2D = this.GetComponent<Rigidbody2D>();
        mRigidbody2D.velocity = new Vector2(20.0f, 0);
        mRigidbody2D.velocity = Quaternion.AngleAxis( Random.Range(0, 360), Vector3.forward) * mRigidbody2D.velocity;
    }

    private void Update()
    {
        
    }
}
