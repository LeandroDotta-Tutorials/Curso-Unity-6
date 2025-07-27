using UnityEngine;

public class Character : MonoBehaviour
{
    [Header("Speeds")]
    [SerializeField] private float walkSpeed = 2;
    [SerializeField] private float runSpeed = 5;

    [Header("Movement Settings")]
    [SerializeField] private float maxWalkMovementStrength = 0.2f;

    private Vector2 movement;
    private float movementStrength;

    private Rigidbody2D rb2d;

    public float Speed => MovementStrength <= maxWalkMovementStrength ? walkSpeed : runSpeed;
    public float MovementStrength
    {
        get => movementStrength;
        private set
        {
            if (value < 0.05f)
            {
                movementStrength = 0;
                movement = Vector2.zero;
                return;
            }
            
            movementStrength = value;
        }
    }
    public bool IsMoving => MovementStrength > 0;
    public bool IsWalking => IsMoving && MovementStrength <= maxWalkMovementStrength;
    public bool IsRunning => IsMoving && !IsWalking;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb2d.linearVelocity = Speed * movement;
    }

    public void Move(Vector2 directionInput)
    {
        movement = directionInput.normalized;
        MovementStrength = Vector2.ClampMagnitude(directionInput, 1).sqrMagnitude;
    }
}
