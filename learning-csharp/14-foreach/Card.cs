public class Card
{
    public int rank;
    public Suit suit;

    public override string ToString()
    {
        return $"[{RankCharacter}{SuitCharacter} ]";
    }

    public string RankCharacter
    {
        get
        {
            return rank switch
            {
                1 => "A",
                11 => "J",
                12 => "Q",
                13 => "K",
                _ => rank.ToString()
            };
        }
    }

    public string SuitCharacter
    {
        get
        {
            return suit switch
            {
                Suit.Hearts => "♥️",
                Suit.Diamonds => "♦️",
                Suit.Clubs => "♣️",
                Suit.Spades => "♠️",
            };
        }
    }
}