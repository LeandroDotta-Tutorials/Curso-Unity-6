using UnityEngine;

public static class TansformExtensions
{
    public static void LookAtDirection2D(this Transform transform, Vector2 direction, Vector2 forward)
    {
        float angleToTarget = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        float angleOfForward = Mathf.Atan2(forward.y, forward.x) * Mathf.Rad2Deg;
        float rotationZ = angleToTarget - angleOfForward;

        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
    }
}
