using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float speed = 5;
    [SerializeField] private SpriteRenderer sprite;

    private Vector3 startPosition;
    private Vector2 endPosition;


    private void Start() 
    {
        startPosition = sprite.transform.localPosition;
        endPosition = startPosition - sprite.bounds.extents;
    }

    private void Update() 
    {
        sprite.transform.Translate(Vector2.down * speed * Time.deltaTime, Space.Self);

        if (sprite.transform.localPosition.y < endPosition.y)
        {
            float delta = sprite.transform.localPosition.y - endPosition.y;

            Vector3 position = startPosition;
            position.y -= delta;
            sprite.transform.localPosition = position;
        }
    }

    private void OnValidate() 
    {
        if (sprite == null)           
        {
            sprite = GetComponentInChildren<SpriteRenderer>();
        }
    }
}
