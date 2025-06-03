using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class Strt : MonoBehaviour
{
    public string room = "0";
    public int layers = 0;
    public int option = 0;
    public string thing = "0";
    [System.NonSerialized]
    public List<string> roomlist = new List<string>() {"g", "t", "b", "u"};
    //g = gambling
    //t = trade (sacrifice)
    //b = base (base card upgrade) (pernament upgrades)
    //u = upgrade (other upgrades) (upgrade hand cards)
    //e = encounter
    [System.NonSerialized]
    public static List<int> deck = new List<int>() {0, 1, 2, 3, 4,0};
    [System.NonSerialized]
    public static List<int> hand = new List<int> {};
    [System.NonSerialized]
    public static List<int> cards = new List<int>() {0, 1, 2, 3, 4,5};
    public static int handSize = 5;
    public static int handCurrent = 0;
    public static List<string> options = new List<string>();
    public static int numberinList = 0;
    public static int numberOfLayer = 0;
    public static int placeNumber = 0;
    public GameObject prefab;
    public GameObject prefab2;
    public Transform transform;
    public GameObject Canvas;
    public cardData cardData;
    void Start()
    {
        room = Random.Range(2, 5).ToString();
        for (int i = 1; i <= int.Parse(room.Substring(0, 1)); i++)
        {
            room = room + "[";
            layers = Random.Range(1, 3);
            room = room + layers.ToString();
            for (int j = 1; j <= layers; j++)
            {
                option = Random.Range(1, 4);
                room = room + option.ToString();
                for (int k = 1; k <= option; k++) {
                    thing = roomlist[Random.Range(0, roomlist.Count)];
                    room = room + thing;
                    options.Add(thing);
                    roomlist.Remove(thing);
                }
                roomlist = new List<string>() {"g", "t", "b", "u"};
            }
            options.Add("e");
        }
        Debug.Log(room);
        for (int i = 0; i < int.Parse(room.Substring(3, 1)); i++)
        {
            Instantiate(prefab, new Vector3((((Canvas.GetComponent<RectTransform>().rect.width / 2) - ((Canvas.GetComponent<RectTransform>().rect.width / (int.Parse(room.Substring(3, 1)) + 1)) * (i + 1))) * Canvas.GetComponent<RectTransform>().localScale.x), 0, 0), Quaternion.identity, transform);
        }
        placeNumber = placeNumber + 3 + int.Parse(room.Substring(3, 1));
        Debug.Log(placeNumber);
    }

    void Update()
    {

    }

    public void startEncounter()
    {
        SceneManager.LoadSceneAsync("gameplay");
    }
    public void startRoom()
    {
        Debug.Log(room.Substring(placeNumber + 1, 1));
        if (room.Substring(placeNumber + 1, 1) == "[")
        {
            for (int i = 0; i < 1; i++)
            {
                Instantiate(prefab, new Vector3(((-800 + ((Canvas.GetComponent<RectTransform>().rect.width / (1)) * (i + 1))) * Canvas.GetComponent<RectTransform>().localScale.x), 0, 0), Quaternion.identity, transform);
            }
            placeNumber = placeNumber + 2;

        } else {
            Debug.Log(room);
            for (int i = 0; i < int.Parse(room.Substring(placeNumber + 1, 1)); i++)
            {
                Instantiate(prefab, new Vector3(((-400 + ((Canvas.GetComponent<RectTransform>().rect.width / (int.Parse(room.Substring(placeNumber + 1, 1)) + 1)) * (i + 1))) * Canvas.GetComponent<RectTransform>().localScale.x), 0, 0), Quaternion.identity, transform);
            }
            placeNumber = placeNumber + int.Parse(room.Substring(placeNumber + 1, 1)) + 1;
        }
        
    }
}
