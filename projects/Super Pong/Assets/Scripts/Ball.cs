using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5;
    public Transform paddleLeft;
    public Transform paddleRight;

    private Vector2 direction = -Vector2.one;

    private void Update() 
    {
        Move();
        BounceTopAndBottom();
        BounceWithPaddles();
    }

    private void Move()
    {
        Vector3 movement = direction * speed * Time.deltaTime;
        transform.Translate(movement);
    }

    private void BounceTopAndBottom()
    {
        float screenTop = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y;
        float screenBottom = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y;

        Vector3 position = transform.position;

        if (direction.y > 0 && position.y >= (screenTop -0.25f))
        {
            direction.y = -1;
        }

        if (direction.y < 0 && position.y <= (screenBottom + 0.25f))
        {
            direction.y = 1;
        }
    }

    private void BounceWithPaddles()
    {
        float paddleWidth = 0.5f;
        float paddleHeight = 2f;

        float ballSize = 0.5f;

        if (direction.x > 0) // Está movendo para a direita
        {
            if ((transform.position.x + ballSize / 2f) > (paddleRight.position.x - paddleWidth / 2f)
            && (transform.position.x + ballSize / 2f) < (paddleRight.position.x + paddleWidth / 2f)
            && transform.position.y > (paddleRight.position.y - paddleHeight / 2f)
            && transform.position.y < (paddleRight.position.y + paddleHeight / 2f))
            {
                direction.x = -1;   
            }
        }
        else if (direction.x < 0) // Está movendo para a esquerda
        {
            if ((transform.position.x - ballSize / 2f) > (paddleLeft.position.x - paddleWidth / 2f)
            && (transform.position.x - ballSize / 2f) < (paddleLeft.position.x + paddleWidth / 2f)
            && transform.position.y > (paddleLeft.position.y - paddleHeight / 2f)
            && transform.position.y < (paddleLeft.position.y + paddleHeight / 2f))
            {
                direction.x = 1;
            }
        }
    }

    public void ResetPosition()
    {
        transform.position = Vector3.zero;
        direction.x = -direction.x;
    }
}
