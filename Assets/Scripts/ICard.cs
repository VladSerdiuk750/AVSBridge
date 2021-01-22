public interface ICard
{
    int Value { get;  set; }
    
    CardSuits Suit { get; set; }
    
    bool isPlayed { get; set; }
    
    bool isPlayable { get; set; }

    void Action(object[] args);
}

public enum CardSuits
{
    Hearts,
    Tiles,
    Clovers,
    Pikes
}