using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "cardData", menuName = "Scriptable Objects/cardData")]
public class cardData : ScriptableObject
{
    public List<Sprite> spriteList = new List<Sprite>();
    public List<int> healthList = new List<int>();
    public List<int> attackList = new List<int>();
    public GameObject mainCard;
}
