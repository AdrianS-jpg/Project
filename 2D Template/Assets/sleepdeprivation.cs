using JetBrains.Annotations;
using UnityEngine;

public class sleepdeprivation : MonoBehaviour
{
    public int cardType;
    public cardData cardData;
    public Transform transform;
    //public GameObject gameObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform = gameObject.GetComponent<Transform>();
        cardType = Strt.deck[Random.Range(0, Strt.deck.Count - 1)];
        Strt.deck.Remove(cardType);
        Strt.hand.Add(cardType);
        gameObject.GetComponent<SpriteRenderer>().sprite = cardData.spriteList[cardType];
        Strt.handCurrent++;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mainCard()
    {
        cardData.mainCard = gameObject;
    }
    public void play()
    {
        if (cardType == 0)
        {

        }
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        maingameplayScript.selectedCard = gameObject;
        Debug.Log(cardType);
    }
}
