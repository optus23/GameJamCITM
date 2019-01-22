using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayer : MonoBehaviour {


    public AudioClip JumpClip;
    public AudioClip DieClip;

    bool can_jump = true;
    public float jump_amount = 250f;
    public Sprite jumping;
    public Sprite idle;
    public float speed;
    private Vector3 spawn;

    private AudioSource audioPlayer;

    void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    void Update ()
    {
        transform.rotation = Quaternion.identity;
        if ((Input.GetKeyDown("up") || Input.GetKeyDown("space") || Input.GetMouseButton(0)) && can_jump)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump_amount));
            can_jump = false;
            audioPlayer.clip = JumpClip;
            audioPlayer.Play();
        }
        if(!can_jump)
        {
            GetComponent<SpriteRenderer>().sprite = jumping;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = idle;
        }
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            can_jump = true;
        }
        if(collision.gameObject.tag == "Ric")
        {
            transform.position = GameObject.Find("Spawn").transform.position;
            audioPlayer.clip = DieClip;
            audioPlayer.Play();
        }
        if(collision.gameObject.tag == "Aprovat")
        {
            //TO DO: WIN
        }
    }
}
