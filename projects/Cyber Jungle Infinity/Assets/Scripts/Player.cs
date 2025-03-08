using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Animator animator;
    private Collider2D coll;
    private PlayerController controller;
    private Gun gun;


    private void Start()
    {
        coll = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();
        controller = GetComponent<PlayerController>();
        gun = GetComponentInChildren<Gun>();
    }

    private void Update()
    {
        UpdateAnimations(controller.direction);
    }

    private void UpdateAnimations(Vector2 direction)
    {
        animator.SetFloat("direction_horizontal", direction.x);
        animator.SetFloat("direction_vertical", direction.y);
    }

    private void OnHealthChange(int health)
    {
        if (health == 0)
        {
            Loose();
            return;
        }

        animator.SetTrigger("take_damage");
    }

    private void OnInvulnerableStart()
    {
        animator.SetBool("blinking", true);
    }

    private void OnInvulnerableEnd()
    {
        animator.SetBool("blinking", false);
    }

    private void Loose()
    {
        animator.SetTrigger("explode");
        coll.enabled = false;
        gun.enabled = false;
        controller.enabled = false;
        Invoke("RestartScene", 2);
    }

    private void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
