using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    public float speed = 15;
    public float maxAngle = 45;

    private int direction = 1;
    private float startingAngleZ;

    private void Start() 
    {
        startingAngleZ = transform.rotation.eulerAngles.z;
    }

    private void Update() 
    {
        transform.Rotate(Vector3.forward, speed * direction * Time.deltaTime);

        ClampRotationToMaxAngle();
    }

    private void ClampRotationToMaxAngle()
    {
        float relativeAngle = NormalizeAngle(transform.rotation.eulerAngles.z - startingAngleZ);

        if (relativeAngle >= maxAngle || relativeAngle <= -maxAngle)
        {
            float fixedAngle = Mathf.Clamp(relativeAngle, -maxAngle, maxAngle);
            transform.rotation = Quaternion.Euler(0f, 0f, startingAngleZ + fixedAngle);

            direction *= -1;
        }
    }

    private float NormalizeAngle(float angle)
    {
        while (angle > 180f) angle -= 360f;
        while (angle < -180f) angle += 360f;
        return angle;
    }
}
