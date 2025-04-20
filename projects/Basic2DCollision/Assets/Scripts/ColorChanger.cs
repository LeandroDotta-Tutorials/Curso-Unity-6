using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color newColor;
    public SpriteRenderer spriteRenderer;

    private Color oldColor;

    private void Start()
    {
        oldColor = spriteRenderer.color;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            spriteRenderer.color = newColor;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            spriteRenderer.color = oldColor;
        }
    }
}
