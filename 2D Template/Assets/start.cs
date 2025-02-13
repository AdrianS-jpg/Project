using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class start : MonoBehaviour
{
    public string room = "0";
    public int layers = 0;
    void Start()
    {
        room = Random.Range(2, 5).ToString();
        for (int i = 1; i <= int.Parse(room.Substring(0, 1)); i++)
        {
            room = room + "[";
            layers = Random.Range(1, 3);
            room = room + layers.ToString();
            room = room + "]";
            for (int j = 1; j <= layers; j++)
            {
                room = room + Random.Range(1, 4).ToString();
            }
        }
        Debug.Log(room);
    }

    void Update()
    {
        
    }

    public void startEncounter()
    {

    }
    public void startRoom()
    {
        room = Random.Range(2, 4).ToString();
        for (int i = 0; i <= int.Parse(room.Substring(0, 1)); i++) 
        {
            room = room + Random.Range(1, 3).ToString();
            for (int j = 0; j <= int.Parse(room.Substring(room.Length - 1,1)); j++)
            {
                room = room + Random.Range(1, 3).ToString();
            }
        }
        Debug.Log(room);
    }
}
