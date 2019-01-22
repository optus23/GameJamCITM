using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Xml;

public class RoomManager : MonoBehaviour {
   
    private SpriteRenderer spriteRenderer ;
    public GameObject propsGameObject;
    public Text roomText;

    [Header("RoomsInfo")]
    public string[] roomsNames;
    public Sprite[] roomsSprites;
    public GameObject[] roomObjectsPrefabs;
    private int currentRoom;

    private XmlDocument xmlDoc = new XmlDocument();

    // Use this for initialization
    void Start () {
        currentRoom = 0;
        GameObject roomSprite = GameObject.Find("RoomSprite");
        spriteRenderer = roomSprite.GetComponent<SpriteRenderer>();
        xmlDoc.Load(Application.dataPath + "/Data/data.xml");
        Save();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void ChangeRoom(int roomId)
    {
        spriteRenderer.sprite = roomsSprites[roomId];
        roomText.text = roomsNames[roomId];
        Object.Destroy(propsGameObject, 0.0f);
        propsGameObject = Instantiate(roomObjectsPrefabs[currentRoom], new Vector3(0, 0, 0), Quaternion.identity);
    }

    void Save()
    {
        XmlElement root = xmlDoc.DocumentElement;
        XmlNode propsNode = root.FirstChild;
        XmlNode roomNode = root.LastChild;

        // Delete previous data
        root.RemoveChild(propsNode);
        root.RemoveChild(roomNode);

        // Save current data
        XmlElement roomElement = xmlDoc.CreateElement("room");
        roomElement.SetAttribute("id", currentRoom.ToString());
        XmlElement propsElement = xmlDoc.CreateElement("props");

        foreach (Transform child in roomObjectsPrefabs[currentRoom].transform)
        {
            XmlElement propElement = xmlDoc.CreateElement("prop");
            propElement.SetAttribute("active", child.gameObject.activeSelf.ToString());
            propsElement.AppendChild(propElement);
        }

        root.AppendChild(propsElement);
        root.AppendChild(roomElement);
        xmlDoc.Save(Application.dataPath + "/Data/data.xml");
    }

    void Load()
    {
        XmlElement root = xmlDoc.DocumentElement;
        XmlNode room = root.FirstChild;
        currentRoom = int.Parse(room.Attributes["active"].Value);
        ChangeRoom(currentRoom);

    }

}
