using JetBrains.Annotations;
using UnityEngine;

public class sleepdeprivation : MonoBehaviour
{
    public int cardType;
    public cardData cardData;
    public int cardDesign;
    public int cardNum;
    public Transform transform;
    public SpriteRenderer card;
    public GameObject health;
    public GameObject attack;
    public SpriteRenderer yeller;
    public SpriteRenderer pre;
    public GameObject explain;
    public GameObject textExplain1;
    public GameObject textExplain2;
    public int lunchCounter = 4;
    //public GameObject gameObject;
    //yo past adrian you stupid

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        transform = gameObject.GetComponent<Transform>();
        cardType = Random.Range(0, Strt.deck.Count);
        cardNum = Strt.cards[cardType];
        cardDesign = Strt.deck[cardType];
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, 0);
        Strt.deck.RemoveAt(cardType);
        Strt.cards.RemoveAt(cardType);
        Strt.hand.Add(cardType);
        card.sprite = cardData.spriteList[cardDesign];
        attackNHealthChnage();
        Strt.handCurrent++;
        if (cardDesign == 1)
        {
            lunchCounter = 4;
        }
        else
        {
            lunchCounter = 0;
        }
        Debug.Log(lunchCounter);
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
        if (cardDesign == 0)
        {
            int att = maingameplayScript.mainCard.GetComponent<sleepdeprivation>().cardData.attackList[maingameplayScript.mainCard.GetComponent<sleepdeprivation>().cardNum];
            maingameplayScript.mainCard.GetComponent<sleepdeprivation>().cardData.attackList[maingameplayScript.mainCard.GetComponent<sleepdeprivation>().cardNum] = att + ((att - (att % 4)) / 4);
            Debug.Log("sadasdasd");
        }
        else if (cardDesign == 1) {
            cardData.attackList[maingameplayScript.mainCard.GetComponent<sleepdeprivation>().cardNum] *= lunchCounter;
            if (lunchCounter == 1)
            {
                lunchCounter = 4;
            } else
            {
                lunchCounter--;
            }
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
                explain.SetActive(false);
                textExplain1.SetActive(false);
                textExplain2.SetActive(false);
            }
            else
            {
                maingameplayScript.selectedCard = gameObject;
            }

            Debug.Log(cardType);
            Debug.Log(cardNum);
            Debug.Log(cardDesign);
        }
    }

    private void OnMouseOver()
    {
        if (maingameplayScript.mainCard != gameObject)
        {
            if (maingameplayScript.selectedCard != gameObject)
            {
                pre.enabled = true;
                explain.SetActive(true);
                textExplain1.SetActive(true);
                textExplain2.SetActive(true);
            }
        }
    }
    private void OnMouseExit()
    {
        if (maingameplayScript.mainCard != gameObject)
        {
            if (maingameplayScript.selectedCard != gameObject)
            {
                pre.enabled = false;
                explain.SetActive(false);
                textExplain1.SetActive(false);
                textExplain2.SetActive(false);

            }
        }

    }

    public void changeSprite(GameObject g, Sprite s)
    {

    }
    //i didnt misspell change i would never
    public void attackNHealthChnage()
    {
        if (cardData.attackList[cardNum] < 10)
        {
            attack.GetComponent<numbers>().numbersprite1.GetComponent<SpriteRenderer>().sprite = cardData.numberList[cardData.attackList[cardNum]];
            attack.GetComponent<numbers>().two = false;
        }
        else
        {
            
            attack.GetComponent<numbers>().numberRun(cardData.attackList[cardNum]);
            attack.GetComponent<numbers>().two = true;

        }
        if (cardData.healthList[cardNum] < 10)
        {
            health.GetComponent<numbers>().numbersprite1.GetComponent<SpriteRenderer>().sprite = cardData.numberList[cardData.healthList[cardNum]];
            health.GetComponent<numbers>().two = false;
        }
        else
        {
            
            health.GetComponent<numbers>().numberRun(cardData.healthList[cardNum]);
            health.GetComponent<numbers>().two = true;
        }
    }
}
