using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5;
    public Transform paddleLeft;
    public Transform paddleRight;

    public SpriteRenderer ballSprite;
    public SpriteRenderer paddleLeftSprite;
    public SpriteRenderer paddleRightSprite;

    public Color primaryColor1;
    public Color primaryColor2;
    public Color primaryColor3;

    public Color backgroundColor1;
    public Color backgroundColor2;
    public Color backgroundColor3;

    private bool isMoving = false;
    private int colorIndex = 1;

    private Vector2 direction = -Vector2.one;

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isMoving)
        {
            isMoving = true;
        }

        Move();
        BounceTopAndBottom();
        BounceWithPaddles();
    }

    private void Move()
    {
        if (isMoving)
        {
            Vector3 movement = direction * speed * Time.deltaTime;
            transform.Translate(movement);
        }
    }

    private void BounceTopAndBottom()
    {
        float screenTop = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y;
        float screenBottom = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y;

        Vector3 position = transform.position;

        if (direction.y > 0 && position.y >= (screenTop -0.25f))
        {
            direction.y = -1;
            SawpColors();
        }

        if (direction.y < 0 && position.y <= (screenBottom + 0.25f))
        {
            direction.y = 1;
            SawpColors();
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
                SawpColors();
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
                SawpColors();
            }
        }
    }

    public void ResetPosition()
    {
        transform.position = Vector3.zero;
        direction.x = -direction.x;
        isMoving = false;
        Invoke("StartMoving", 2);
    }

    private void StartMoving()
    {
        isMoving = true;
    }

    private void SawpColors()
    {
        Color primaryColor = Color.white;
        Color backgroundColor = Color.white;

        if (colorIndex == 1)
        {
            colorIndex = 2;
            primaryColor = primaryColor2;
            backgroundColor = backgroundColor2;
        }
        else if (colorIndex == 2)
        {
            colorIndex = 3;
            primaryColor = primaryColor3;
            backgroundColor = backgroundColor3;
        }
        else if (colorIndex == 3)
        {
            colorIndex = 1;
            primaryColor = primaryColor1;
            backgroundColor = backgroundColor1;
        }

        ballSprite.color = primaryColor;
        paddleLeftSprite.color = primaryColor;
        paddleRightSprite.color = primaryColor;
        Camera.main.backgroundColor = backgroundColor;
    }
}
