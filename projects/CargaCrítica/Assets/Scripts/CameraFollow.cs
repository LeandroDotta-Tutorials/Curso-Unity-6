using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;

    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - target.position;
    }
    
    private void LateUpdate() 
    {
        Vector3 position = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, position, smoothSpeed);
    }
}
