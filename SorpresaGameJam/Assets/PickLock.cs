using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickLock : MonoBehaviour {
    public Camera camera;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
               if(hit.collider.tag == "Clip")
                {
                    hit.collider.gameObject.transform.position = Input.mousePosition;
                    Debug.Log("lockpit");
                }
            }
        }
	}
}
