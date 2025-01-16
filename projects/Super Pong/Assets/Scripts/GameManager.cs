using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int scorePlayer1 = 0;
    public int scorePlayer2 = 0;

    public int pointsToIncreaseSpeed = 3;
    public float speedIncrement = 0.1f;

    public Ball ball;
    public Text score;

    private void Update() 
    {
        float screenLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x;
        float screenRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x;

        if (ball.transform.position.x + 0.25f < screenLeft)
        {
            AddScore(2);
            ball.ResetPosition();
        }
        else if (ball.transform.position.x - 0.25f > screenRight)
        {
            AddScore(1);
            ball.ResetPosition();
        }
    }

    public void AddScore(int player)
    {
        if (player == 1)
        {
            scorePlayer1++;
        }
        else if (player == 2)
        {
            scorePlayer2++;
        }

        if ((scorePlayer1 + scorePlayer2) % pointsToIncreaseSpeed == 0)
        {
            ball.speed += speedIncrement;
        }

        score.text = $"{scorePlayer1} x {scorePlayer2}";
    }
}
