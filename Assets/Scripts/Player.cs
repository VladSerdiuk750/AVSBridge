using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string Name { get; set; }
    
    public int Points { get; set; }

    public List<ICard> CardsInHand { get; set; }
}