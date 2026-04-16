using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float forwardSpeed = 20;
    [SerializeField] private float backwardSpeed = 10;
    [SerializeField] private float turnSensitivity = 100f;

    private float movementInput = 0;
    private float turnInput = 0;

    private Rigidbody rb;

    public bool IsMoving => Mathf.Abs(movementInput) > 0.1f;

    private void Start() 
    {
        rb = GetComponent<Rigidbody>();    
    }

    private void FixedUpdate()
    {
        HandleMovement();
        HandleTurn();
    }

    private void HandleMovement()
    {
        float targetSpeed = (movementInput > 0) ? forwardSpeed : backwardSpeed;

        Vector3 movement = transform.forward * movementInput * targetSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);
    }
    
    private void HandleTurn()
    {
        if (!IsMoving) return;

        // Reverse turn direction if moving backward
        float direction = (movementInput > 0) ? 1f : -1f;
        float turnAmount = turnInput * turnSensitivity * direction * Time.fixedDeltaTime;

        Quaternion turnRotation = Quaternion.Euler(0, turnAmount, 0);
        rb.MoveRotation(rb.rotation * turnRotation);
    }

    public void OnAccelerate(InputValue value)
    {
        movementInput = value.isPressed ? 1 : 0;
    }

    public void OnBrake(InputValue value)
    {
        movementInput = value.isPressed ? -1 : 0;
    }
    
    public void OnTurn(InputValue value)
    {
        turnInput = value.Get<float>();
    }
}