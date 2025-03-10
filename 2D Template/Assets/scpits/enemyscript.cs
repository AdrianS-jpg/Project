using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    public float enemyattack;
    public float enemyhealth;
    void Start()
    {

    }

    void Update()
    {

    }

    public void enemyturn()
    {
        enemyhealth = enemyhealth - FindObjectOfType<mainscript>().mainattack;
    }
}