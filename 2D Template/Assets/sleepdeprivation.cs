using JetBrains.Annotations;
using UnityEngine;

public class sleepdeprivation : MonoBehaviour
{
    public int cardType;
    public cardData cardData;
    public Transform transform;
    public SpriteRenderer card;
    public SpriteRenderer health;
    public SpriteRenderer attack;
    public SpriteRenderer yeller;
    //public GameObject gameObject;
    //yo past adrian you stupid

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform = gameObject.GetComponent<Transform>();
        cardType = Strt.deck[Random.Range(0, Strt.deck.Count - 1)];
        Strt.deck.Remove(cardType);
        Strt.hand.Add(cardType);
        card.sprite = cardData.spriteList[cardType];
        attack.sprite = cardData.numberList[cardData.attackList[cardType]];
        health.sprite = cardData.numberList[cardData.healthList[cardType]];
        Strt.handCurrent++;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (maingameplayScript.selectedCard == gameObject)
        {
            //dude how do you forgot the double equals AGAIN
            //me stupid
            //fair enough
            yeller.GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            yeller.GetComponent<SpriteRenderer>().enabled = false;
        }
    }


    public void mainCard()
    {
        cardData.mainCard = gameObject;
        transform.position = new Vector3(0,0,0);
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
        if (maingameplayScript.selectedCard == gameObject)
        {
            maingameplayScript.selectedCard = null;
        }
        else
        {
            maingameplayScript.selectedCard = gameObject;
        }

        Debug.Log(cardType);
    }

    public void changeSprite(GameObject g, Sprite s)
    {

    }
}
