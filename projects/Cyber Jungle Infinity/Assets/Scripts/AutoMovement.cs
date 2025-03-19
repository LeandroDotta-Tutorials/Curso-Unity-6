using UnityEngine;

public class AutoMovement : MonoBehaviour
{
    public float speed = 5;
    public Vector2 direction = Vector2.down;

    private void Update()
    {
        transform.Translate(speed * Time.deltaTime * direction, Space.World);
    }
}
