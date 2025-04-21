using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public Vector2 Direction { get; private set; } = Vector2.zero;

    private Collider2D coll;

    private void Start()
    {
        coll = GetComponent<Collider2D>();
    }

    private void OnDisable()
    {
        Direction = Vector2.zero;
    }

    private void Update()
    {
        Direction = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        ).normalized;

        transform.Translate(speed * Time.deltaTime * Direction);

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
}
