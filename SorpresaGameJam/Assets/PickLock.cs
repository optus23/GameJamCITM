using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickLock : MonoBehaviour {

    private Vector3 spawn;
    private Vector3 screenPoint;
    private Vector3 offset;
    private bool reset = false;

    public AudioClip DieClip;
    private AudioSource audioPlayer;

    private void Start()
    {
        spawn = GameObject.Find("StartPoint").transform.position;
        audioPlayer = GetComponent<AudioSource>();

    }

    private void Update()
    {
        if (reset)
        {
            spawn = GameObject.Find("StartPoint").transform.position;
            transform.position = spawn;
        }
            
    }

    void OnMouseDown()
    {
        reset = false;
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "UnLocked")
        {
            Debug.Log("UNLOCKED");
            //win

        }
        else
        {
            Debug.Log("Key Colliding");
            transform.position = spawn;
            audioPlayer.clip = DieClip;
            audioPlayer.Play();
            reset = true;
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "UnLocked")
        {
            transform.position = spawn;
        }
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }

    void OnMouseUp()
    {
        transform.position = spawn;
    }


}

 //   public Camera camera;
	//// Use this for initialization
	//void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {

 //       Vector3 screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

 //       if (Input.GetMouseButtonDown(0))
 //       {
 //           RaycastHit hit;
 //           Ray ray = camera.ScreenPointToRay(Input.mousePosition);
 //           if (Physics.Raycast(ray, out hit))
 //           {
 //              if(hit.collider.tag == "Clip")
 //               {
 //                   hit.collider.gameObject.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
 //                   Debug.Log("lockpit");
 //               }
 //           }
 //       }
	//}

