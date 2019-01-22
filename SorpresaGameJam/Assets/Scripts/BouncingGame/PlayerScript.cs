using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

    private Vector3 offset;
    private Rigidbody2D mRigidbody2D;
    private bool updatePosition = false;
    private BouncingGameManager gameManager;

    public AudioClip DieClip;
    private AudioSource audioPlayer;


    // Use this for initialization
    void Start()
    {
        offset.Set(0.0f, 0.0f, 0.0f);
        mRigidbody2D = this.GetComponent<Rigidbody2D>();
        gameManager = GameObject.FindObjectOfType<BouncingGameManager>();
        audioPlayer = GetComponent<AudioSource>();

    }

    private void FixedUpdate()
    {
        mRigidbody2D.velocity = new Vector2(0, 0);
        mRigidbody2D.angularVelocity = 0.0f;

        if (updatePosition)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.0f));
            transform.position = mousePos + offset;
        }

        updatePosition = false;
    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.0f));
    }

    private void OnMouseDrag()
    {
        updatePosition = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.tag == "Ball")
        {
            gameManager.GameOver();
            audioPlayer.clip = DieClip;
            audioPlayer.Play();
        }
    }
}
