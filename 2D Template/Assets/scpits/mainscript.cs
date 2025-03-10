using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainscript : MonoBehaviour
{
    public float mainattack;
    public float mainhealth;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void mainturn()
    {
        mainhealth = mainhealth - FindObjectOfType<enemyscript>().enemyattack;
    }
}
