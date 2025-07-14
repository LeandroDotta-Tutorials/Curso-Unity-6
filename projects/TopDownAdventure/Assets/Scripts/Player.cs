using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Interaction Settings")]
    [SerializeField] private float interactionDistance = 1.5f;
    [SerializeField] private LayerMask interactableLayer;

    private Vector2 lastDirection;
    private IInteractable currentInteractable;
    private GameObject currentDetectedObject;

    private Animator animator;
    private Character character;
    private PlayerController controller;

    private void Start()
    {
        animator = GetComponent<Animator>();
        character = GetComponent<Character>();
        controller = GetComponent<PlayerController>();
    }

    private void Update()
    {
        DetectInteractable();

        character.Move(controller.Direction);

        bool isWalking = controller.Direction != Vector2.zero;

        animator.SetBool("walking", isWalking);
        if (isWalking)
        {
            animator.SetFloat("directionX", controller.Direction.x);
            animator.SetFloat("directionY", controller.Direction.y);

            lastDirection = controller.Direction;
        }
    }

    private void OnInteractPressed()
    {
        currentInteractable?.Interact();
    }

    private void DetectInteractable()
    {
        // Cast the ray to the last direction of the Player
        Vector2 origin = transform.position;
        RaycastHit2D hit = Physics2D.Raycast(origin, lastDirection, interactionDistance, interactableLayer);

        // Draw the ray in the Scene;
        Debug.DrawRay(origin, lastDirection * interactionDistance, Color.red);

        // Clear the detected object if nothing is detected
        if (hit.collider == null)
        {
            currentInteractable?.OnFocusEnd();

            currentDetectedObject = null;
            currentInteractable = null;
            return;
        }

        // Update the detected object if required
        GameObject hitObject = hit.collider.gameObject;

        if (hitObject == currentDetectedObject) return;

        currentDetectedObject = hitObject;
        currentInteractable = hitObject.GetComponent<IInteractable>();
        currentInteractable.OnFocusStart();
    }

}
