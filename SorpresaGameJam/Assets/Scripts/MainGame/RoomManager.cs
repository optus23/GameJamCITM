using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RoomManager : MonoBehaviour {
   
    private SpriteRenderer spriteRenderer ;
    public Text roomText;

    [Header("RoomsInfo")]
    public string[] roomsNames;
    public Sprite[] roomsSprites;
    public GameObject[] roomObjects;

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

    void ChangeRoom(int roomId)
    {
        spriteRenderer.sprite = roomsSprites[roomId];
        roomText.text = roomsNames[roomId];
    }


}
