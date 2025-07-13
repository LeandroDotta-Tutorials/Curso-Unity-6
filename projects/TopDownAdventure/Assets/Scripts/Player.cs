using UnityEngine;

public class Player : MonoBehaviour
{
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
        character.Move(controller.Direction);

        bool isWalking = controller.Direction != Vector2.zero;

        animator.SetBool("walking", isWalking);
        if (isWalking)
        {
            animator.SetFloat("directionX", controller.Direction.x);
            animator.SetFloat("directionY", controller.Direction.y);
        }
    }

}
