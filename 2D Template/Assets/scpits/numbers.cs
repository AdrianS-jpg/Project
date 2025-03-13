using UnityEngine;

public class numbers : MonoBehaviour
{
    public GameObject numbersprite1;
    public GameObject numbersprite2;
    public cardData cardData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void numberRun(int number)
    {
        if (number >= 10)
        {
            numbersprite1.GetComponent<SpriteRenderer>().enabled = true;
            numbersprite2.GetComponent<SpriteRenderer>().enabled = true;
            Debug.Log((number - (number % 10)) / 10);
            Debug.Log(number % 10);
            numbersprite1.GetComponent<SpriteRenderer>().sprite = cardData.numberList[(number - (number % 10)) / 10];
            numbersprite2.GetComponent<SpriteRenderer>().sprite = cardData.numberList[number % 10];
            numbersprite1.GetComponent<Transform>().localScale = new Vector3(numbersprite1.GetComponent<Transform>().localScale.x, numbersprite1.GetComponent<Transform>().localScale.y, numbersprite1.GetComponent<Transform>().localScale.z);
            numbersprite2.GetComponent<Transform>().localScale = new Vector3(numbersprite2.GetComponent<Transform>().localScale.x, numbersprite1.GetComponent<Transform>().localScale.y, numbersprite1.GetComponent<Transform>().localScale.z);
            numbersprite1.GetComponent<Transform>().localPosition = new Vector3(numbersprite1.GetComponent<Transform>().localPosition.x + 3.25f, numbersprite1.GetComponent<Transform>().localPosition.y, numbersprite1.GetComponent<Transform>().localPosition.z);
            numbersprite2.GetComponent<Transform>().localPosition = new Vector3(numbersprite2.GetComponent<Transform>().localPosition.x - 3.25f, numbersprite2.GetComponent<Transform>().localPosition.y, numbersprite2.GetComponent<Transform>().localPosition.z);

        }
    }
}
