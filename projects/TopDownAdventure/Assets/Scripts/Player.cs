using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Interaction Settings")]
    [SerializeField] private float interactionDistance = 1.5f;
    [SerializeField] private LayerMask interactableLayer;

    private Vector2 lookDirection = Vector2.down;
    private IInteractable currentInteractable;
    private GameObject currentDetectedObject;

    private Animator animator;
    private Character character;
    private PlayerController controller;
    private Gun gun;

    private void Start()
    {
        animator = GetComponent<Animator>();
        character = GetComponent<Character>();
        controller = GetComponent<PlayerController>();
        gun = GetComponentInChildren<Gun>();
    }

    private void Update()
    {
        DetectInteractable();

        character.Move(controller.Direction);

        if (character.IsMoving && !controller.IsAiming)
        {
            lookDirection = controller.Direction.normalized;
        }

        if (controller.IsShooting)
        {
            gun.Shoot(lookDirection);
        }

        animator.SetFloat("directionX", lookDirection.x);
        animator.SetFloat("directionY", lookDirection.y);
        animator.SetBool("walking", character.IsWalking);
        animator.SetBool("running", character.IsRunning);
    }

    private void OnInteractPressed()
    {
        currentInteractable?.Interact();
    }

    private void DetectInteractable()
    {
        // Cast the ray to the last direction of the Player
        Vector2 origin = transform.position;
        RaycastHit2D hit = Physics2D.Raycast(origin, lookDirection, interactionDistance, interactableLayer);

        // Draw the ray in the Scene;
        Debug.DrawRay(origin, lookDirection * interactionDistance, Color.red);

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
