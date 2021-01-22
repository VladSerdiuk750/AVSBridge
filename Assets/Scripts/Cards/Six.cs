using UnityEngine;

public class Six : MonoBehaviour, ICard
{
    private int _value;

    public int Value
    {
        get => _value;
        
        set
        {
            if (value < 0)
            {
                _value = 0;
            }
            _value = value;
        }
    }
    
    public CardSuits Suit { get; set; }
    
    public bool isPlayed { get; set; }
    
    public bool isPlayable { get; set; }
    
    
    public void Action(object[] args)
    {
        // next player get 2 cards and have turn
    }
}