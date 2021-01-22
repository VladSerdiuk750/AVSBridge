using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private Player currentPlayer;

    [SerializeField] private Player nextPlayer;

    [SerializeField] private List<Player> players;

    public List<Card> deck;

    private void Update()
    {
        
    }
}
