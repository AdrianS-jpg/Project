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
        attackNHealthChnage();
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
        maingameplayScript.mainCard = gameObject;
        
        transform.position = new Vector3(0,0,0);
    }
    public void play()
    {
        if (cardType == 0)
        {
            int att = maingameplayScript.mainCard.GetComponent<sleepdeprivation>().cardData.attackList[maingameplayScript.mainCard.GetComponent<sleepdeprivation>().cardType];
            maingameplayScript.mainCard.GetComponent<sleepdeprivation>().cardData.attackList[maingameplayScript.mainCard.GetComponent<sleepdeprivation>().cardType] = att + ((att - (att%4)) / 4);
        }
        maingameplayScript.mainCard.GetComponent<sleepdeprivation>().attackNHealthChnage();
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        if (maingameplayScript.mainCard != gameObject)
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
    //i didnt misspell change i would never
    public void attackNHealthChnage()
    {
        if (cardData.attackList[cardType] < 10)
        {
            attack.GetComponent<numbers>().numbersprite1.GetComponent<SpriteRenderer>().sprite = cardData.numberList[cardData.attackList[cardType]];
            attack.GetComponent<numbers>().two = false;
        }
        else
        {
            
            attack.GetComponent<numbers>().numberRun(cardData.attackList[cardType]);
            attack.GetComponent<numbers>().two = true;

        }
        if (cardData.healthList[cardType] < 10)
        {
            health.GetComponent<numbers>().numbersprite1.GetComponent<SpriteRenderer>().sprite = cardData.numberList[cardData.healthList[cardType]];
            health.GetComponent<numbers>().two = false;
        }
        else
        {
            
            health.GetComponent<numbers>().numberRun(cardData.healthList[cardType]);
            health.GetComponent<numbers>().two = true;
        }
    }
}
