using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;

    private void Update()
    {
        Vector2 direction = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        );

        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"Player INICIOU colisão com: {collision.gameObject.name}");

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log($"Player SAIU da colisão com: {collision.gameObject.name}");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log($"Player AINDA ESTÀ em colisão com: {collision.gameObject.name}");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"Player INICIOU trigger com: {other.name}");

        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log($"Player SAIU da trigger: {other.name}");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log($"Player AINDA ESTÁ da trigger: {other.name}");
    }
}
