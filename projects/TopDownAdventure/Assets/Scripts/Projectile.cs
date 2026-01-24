using UnityEngine;

public class Projectile : MonoBehaviour
{
    public LayerMask ignoreLayers;
    [SerializeField] private Transform spriteTransform;

    private Collider2D coll;
    private AutoMovement autoMovement;
    private Animator animator;

    public Vector2 Direction { get; set; }

    private void Start()
    {
        coll = GetComponent<Collider2D>();
        autoMovement = GetComponent<AutoMovement>();
        animator = GetComponent<Animator>();

        autoMovement.direction = Direction;
        spriteTransform.LookAtDirection2D(Direction, Vector2.right);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the other object's layer is in the ignoreLayers mask
        if (((1 << other.gameObject.layer) & ignoreLayers.value) != 0)
        {
            // It's in the ignore list — do nothing
            return;
        }

        Hit();
    }

    private void Hit()
    {
        animator.SetTrigger("hit");
        autoMovement.enabled = false;
        coll.enabled = false;

        Invoke(nameof(DestroySelf), 1f);
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }

    private void LookAtDirection(Vector2 direction, Vector2 forward)
    {
        float angleToTarget = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        float angleOfForward = Mathf.Atan2(forward.y, forward.x) * Mathf.Rad2Deg;
        float rotationZ = angleToTarget - angleOfForward;

        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
    }
}
