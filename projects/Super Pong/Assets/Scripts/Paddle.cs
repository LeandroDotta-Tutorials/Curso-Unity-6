using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 5;
    public KeyCode inputKeyUp = KeyCode.W;
    public KeyCode inputKeyDown = KeyCode.S;

    private void Update()
    {
        float movement = ProcessInput();
        Move(movement);
        ClampPositionToScreen();
    }

    private float ProcessInput()
    {
        float movement = 0;

        if (Input.GetKey(inputKeyUp))
        {
            movement = 1;
        }

        if (Input.GetKey(inputKeyDown))
        {
            movement = -1;
        }

        return movement;
    }

    private void Move(float movement)
    {
        transform.Translate(0, movement * speed * Time.deltaTime, 0);
    }

    private void ClampPositionToScreen()
    {
        float maxPositionY = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y;
        float minPositionY = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y;

        Vector3 position = transform.position;
        position.y = Mathf.Clamp(position.y, minPositionY + 1, maxPositionY - 1);
        transform.position = position;
    }
}
