using UnityEngine;

public class AutoMovement : MonoBehaviour
{
    public float speed = 5;
    public bool moveFront;
    public Vector2 direction = Vector2.down;

    private void Update()
    {
        Vector2 dir = moveFront ? transform.up : direction;
        transform.Translate(speed * Time.deltaTime * dir, Space.World);
    }
}
