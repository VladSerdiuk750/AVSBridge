using System;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string Name { get; set; }

    public int Points { get; set; }

    [SerializeField] private List<Card> cardsInHand;

    public List<Card> CardsInHand => cardsInHand;

    private void Start()
    {
        cardsInHand = new List<Card>();
    }
}