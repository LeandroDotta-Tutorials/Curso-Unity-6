using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float speed = 5;
    public SpriteRenderer sprite;

    private float startPositionY;
    private float endPositionY;


    private void Start()
    {
        startPositionY = sprite.transform.localPosition.y;
        endPositionY = startPositionY - sprite.bounds.extents.y;
    }

    private void Update() 
    {
        sprite.transform.Translate(Vector2.down * speed * Time.deltaTime, Space.World);

        Vector3 position = sprite.transform.localPosition;
        if (position.y < endPositionY)
        {
            float delta = sprite.transform.localPosition.y - endPositionY;

            position.y = startPositionY - delta;
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
