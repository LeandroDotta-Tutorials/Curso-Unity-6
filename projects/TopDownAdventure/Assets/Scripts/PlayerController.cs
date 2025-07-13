using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector2 Direction { get; private set; }

    private void Update()
    {
        Direction = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );
    }
}
