using JetBrains.Annotations;
using UnityEngine;

public class sleepdeprivation : MonoBehaviour
{
    public int cardType;
    public cardData cardData;
    public Transform transform;
    public SpriteRenderer card;
    public GameObject health;
    public GameObject attack;
    public SpriteRenderer yeller;
    public SpriteRenderer pre;
    //public GameObject gameObject;
    //yo past adrian you stupid

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform = gameObject.GetComponent<Transform>();
        cardType = Strt.deck[Random.Range(0, Strt.deck.Count - 1)];
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, 0);
        Strt.deck.Remove(cardType);
        Strt.hand.Add(cardType);
        card.sprite = cardData.spriteList[cardType];
        attack.GetComponent<numbers>().numbersprite1.GetComponent<SpriteRenderer>().sprite = cardData.numberList[cardData.attackList[cardType]];
        health.GetComponent<numbers>().numbersprite1.GetComponent<SpriteRenderer>().sprite = cardData.numberList[cardData.healthList[cardType]];
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
        if (cardData.mainCard != gameObject)
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
    }

    private void OnMouseOver()
    {
        if (cardData.mainCard != gameObject)
        {
            pre.enabled = true;
        }
    }
    private void OnMouseExit()
    {
        if (cardData.mainCard != gameObject)
        {
            pre.enabled = false;
        }
    }

    public void changeSprite(GameObject g, Sprite s)
    {

    }
}
