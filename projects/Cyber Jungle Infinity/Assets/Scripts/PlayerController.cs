using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;

    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private Collider2D coll;

    private void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        coll = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();
    }

    private void Update() 
    {
        Vector2 direction = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        ).normalized;

        transform.Translate(speed * Time.deltaTime * direction);

        UpdateAnimations(direction);
        ClampPositionToScreen();
    }

    private void ClampPositionToScreen()
    {
        Vector3 maxPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        Vector3 minPosition = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));

        Vector2 extents = coll.bounds.extents;

        minPosition.x += extents.x;
        minPosition.y += extents.y;

        maxPosition.x -= extents.x;
        maxPosition.y -= extents.y;

        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, minPosition.x, maxPosition.x);
        position.y = Mathf.Clamp(position.y, minPosition.y, maxPosition.y);
        transform.position = position;
    }

    private void UpdateAnimations(Vector2 direction)
    {
        animator.SetFloat("direction_horizontal", direction.x);
        animator.SetFloat("direction_vertical", direction.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("On trigger enter");

        if (other.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
