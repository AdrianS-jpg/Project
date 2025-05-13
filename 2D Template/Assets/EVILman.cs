using UnityEngine;

public class EVILman : MonoBehaviour
{
    public cardData cardData;
    public Transform transform;
    public SpriteRenderer card;
    public GameObject health;
    public GameObject attack;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        card.sprite = cardData.evilman;
        if (cardData.evilAttack < 10)
        {
            attack.GetComponent<numbers>().numbersprite1.GetComponent<SpriteRenderer>().sprite = cardData.numberList[cardData.evilAttack];
        }
        else
        {
            attack.GetComponent<numbers>().numberRun(cardData.evilAttack);

        }
        if (cardData.evilHealth < 10)
        {
            health.GetComponent<numbers>().numbersprite1.GetComponent<SpriteRenderer>().sprite = cardData.numberList[cardData.evilHealth];
        }
        else
        {
            health.GetComponent<numbers>().numberRun(cardData.evilHealth);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
