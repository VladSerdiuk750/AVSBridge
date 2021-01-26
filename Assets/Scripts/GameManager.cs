using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private Player currentPlayer;

    [SerializeField] private Player nextPlayer;

    [SerializeField] private List<Player> players;

    [SerializeField] private List<Card> deck;

    [SerializeField] private int numberOfCards;
    
    [SerializeField] private int cardWidth;

    [SerializeField] private int cardOffset;

    private void Start()
    {
        for (int i = 0; i < players.Count; i++)
        {
            for (int j = 0; j < numberOfCards; j++)
            {
                var cardIndex = Random.Range(0, deck.Count);
                players[i].CardsInHand.Add(deck[cardIndex]);
                deck.RemoveAt(cardIndex);
            }
        }

        currentPlayer = players[0];
        ShowCards(currentPlayer);
    }

    void ShowCards(Player player)
    {
        if (player.CardsInHand is null) return;

        for (int i = 0; i < player.CardsInHand.Count; i++)
        {
            var cardPosition = new Vector3(player.transform.position.x + i * cardWidth + cardOffset, player.transform.position.y, player.transform.position.z);
            Instantiate(player.CardsInHand[i], cardPosition, Quaternion.identity, player.transform);
        }
    }
    
    private void Update()
    {
        
    }
}
