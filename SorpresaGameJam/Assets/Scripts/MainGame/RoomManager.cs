using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RoomManager : MonoBehaviour {
   
    public SpriteRenderer spriteRenderer ;
    public Text roomText;

    [Header("RoomsInfo")]
    public Sprite[] roomsSprites;
    public string[] roomsNames;
   

    int currentRoom;
	// Use this for initialization

	void Start () {
        currentRoom = 0;
        GameObject roomSprite = GameObject.Find("RoomSprite");
        spriteRenderer = roomSprite.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}



}
