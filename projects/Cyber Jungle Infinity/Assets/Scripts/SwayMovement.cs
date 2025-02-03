using UnityEngine;

public class SwayMovement : MonoBehaviour
{
    public float speed = 3;

    public float leftLimit = 2;
    public float rightLimit = 2;

    private float startPositionX;
    private float direction = 1;

    private float MaxPositionX => startPositionX + rightLimit;
    private float MinPositionX => startPositionX - leftLimit;
    

    private void Start() 
    {
        startPositionX = transform.position.x;    
    }

    private void Update() 
    {
        transform.Translate(direction * speed * Time.deltaTime, 0, 0);

        if (transform.position.x > MaxPositionX || transform.position.x < MinPositionX) 
        {
            Vector3 position = transform.position;
            position.x = Mathf.Clamp(position.x, MinPositionX, MaxPositionX);
            transform.position = position;

            direction *= -1;
        }
    }
}
