using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dissapear : MonoBehaviour {

    private void OnMouseDown()
    {
        Destroy(GameObject.Find("books_left"));
    }

}
