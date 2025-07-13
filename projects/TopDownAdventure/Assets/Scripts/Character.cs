using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private float speed = 5;

    private Vector2 movement;

    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb2d.linearVelocity = speed * movement;
    }

    public void Move(Vector2 direction)
    {
        movement = direction.normalized;
    }
}
