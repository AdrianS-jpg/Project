using System.Collections.Generic;
using Unity.Multiplayer.Center.Common;
using UnityEngine;

public class maingameplayScript : MonoBehaviour
{
    public static List<int> deck = Strt.deck;
    public static List<int> hand = Strt.hand;
    public static List<int> cards = Strt.cards;
    public static GameObject selectedCard;
    public Transform transform;
    public GameObject Canvas;
    public GameObject prefab;
    public cardData cardData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < Strt.handSize; i++)
        {
            Instantiate(prefab, new Vector3((((Canvas.GetComponent<RectTransform>().rect.width / 2) - ((Canvas.GetComponent<RectTransform>().rect.width / (Strt.handSize + 1)) * (i + 1))) * Canvas.GetComponent<RectTransform>().localScale.x), -2, 0), Quaternion.identity, transform);
            Debug.Log("work");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void mained()
    {
        if (selectedCard != null)
        {
            selectedCard.GetComponent<sleepdeprivation>().mainCard();
        }
    }

    public void played()
    {
        if (selectedCard != null)
        {
            selectedCard.GetComponent<sleepdeprivation>().play();
        }
    }
}
