public class ScoreManager
{
    public int Score { get; set; }
    public int MaxScore { get; private set; }

    public ScoreManager(Enemy[] levelEnemies)
    {
        foreach (Enemy enemy in levelEnemies)
        {
            MaxScore += enemy.score;
        }
    }

    public int CalculateRating()
    {
        int rating = 0;

        float scorePercentage = (float)Score / MaxScore * 100;

        if (scorePercentage >= 100f)
        {
            rating = 3;
        }
        else if (scorePercentage >= 75f)
        {
            rating = 2;
        }
        else if (scorePercentage >= 50f)
        {
            rating = 1;
        }

        return rating;
    }
}
