using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scip : MonoBehaviour {

    public GameObject board;

    public float MoveSpeed = 20.0F;

    private Rigidbody2D mRigidbody2D;

    private float mMovementX = 0;
    private float mMovementY = 0;

    void Awake()
    {
        mRigidbody2D = this.GetComponent<Rigidbody2D>();


        mMovementX = UnityEngine.Random.Range(10F, 15F);
        mMovementY = UnityEngine.Random.Range(10F, 15F);

        mRigidbody2D.velocity = new Vector2(mMovementX, mMovementY);
    }

    void Update()
    {
        //InvokeRepeating("Awake", 5.0f,5.0f);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Vector3 normal = (board.transform.position - transform.position).normalized;

        mRigidbody2D.velocity = Vector2.Reflect(mRigidbody2D.velocity, normal);
    }
}
