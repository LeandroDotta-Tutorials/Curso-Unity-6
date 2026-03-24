string[] tags = { "c#", "unity", "gamedev", "programação", "2D", "3D" };

foreach (string tag in tags)
{
    int charCount = tag.Length;

    Console.WriteLine($"🏷️  {tag,-15} ({charCount} Letras)");
}

Card[] cards =
{
    new Card { rank = 1, suit = Suit.Spades },
    new Card { rank = 2, suit = Suit.Hearts },
    new Card { rank = 11, suit = Suit.Diamonds },
    new Card { rank = 12, suit = Suit.Clubs },
    new Card { rank = 13, suit = Suit.Spades },
};

foreach (var card in cards)
{
    Console.WriteLine(card);
}