public class Scoreboard
{
    public Player player1;
    public Player player2;
    public int maxScore;

    public Scoreboard(string namePlayer1, string namePlayer2, int maxScore)
    {
        player1 = new Player(namePlayer1);
        player2 = new Player(namePlayer2);
        this.maxScore = maxScore;
    }

    public bool AddScore(int player, int score)
    {
        if (player == 1)
        {
            player1.score += score;
        }
        else if (player == 2)
        {
            player2.score += score;
        }

        Console.WriteLine($"Placar: [{player1.name} {player1.score} X {player2.score} {player2.name}]");

        return player1.score >= maxScore || player2.score >= maxScore;
    }

    public Player GetWinner()
    {
        if (player1.score > player2.score)
        {
            return player1;
        }
        else if (player2.score > player1.score)
        {
            return player2;
        }
        else
        {
            return null;
        }
    }
}