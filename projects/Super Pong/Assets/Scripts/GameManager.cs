using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int scorePlayer1 = 0;
    public int scorePlayer2 = 0;

    public Transform ball;
    public Text score;

    private void Update() 
    {
        float screenLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x;
        float screenRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x;

        if (ball.position.x + 0.25f < screenLeft)
        {
            AddScore(2);
            ResetBallPosition();
        }
        else if (ball.position.x - 0.25f > screenRight)
        {
            AddScore(1);
            ResetBallPosition();
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

        score.text = $"{scorePlayer1} x {scorePlayer2}";
    }

    public void ResetBallPosition()
    {
        ball.position = Vector3.zero;
    }
}
