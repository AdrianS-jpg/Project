using JetBrains.Annotations;
using UnityEngine;

public class sleepdeprivation : MonoBehaviour
{
    public int cardType;
    //public GameObject gameObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cardType = Strt.deck[Random.Range(0, Strt.deck.Count - 1)];
        Strt.deck.Remove(cardType);
        Strt.hand.Add(cardType);
        Strt.handCurrent++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
        Destroy(gameObject);
    }

    private void OnMouseDown()
    {
        maingameplayScript.selectedCard = gameObject;
        Debug.Log(cardType);
    }
}
