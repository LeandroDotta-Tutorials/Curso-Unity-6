using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Serializable]
    public struct AxisLocks
    {
        public bool x;
        public bool y;
        public bool z;

        public Vector3 Apply(Vector3 position, Vector3 lockedPosition)
        {
            if (x) position.x = lockedPosition.x;
            if (y) position.y = lockedPosition.y;
            if (z) position.z = lockedPosition.z;
            return position;
        }
    }

    public Transform target;
    [Min(0f)] 
    public float speed = 0.2f;
    public AxisLocks lockedAxes;
    public bool snapToTargetOnStart = true;

    private Vector3 offset;
    private Vector3 initialPosition;

    private void Start()
    {
        if (target == null)
        {
            Debug.LogWarning($"{nameof(CameraFollow)} on {name} has no target assigned", this);
            enabled = false;
            return;
        }

        InitializeFollowState(snapToTargetOnStart);
    }

    private void InitializeFollowState(bool snapToTarget)
    {
        if (snapToTarget)
        {
            Vector3 snappedPosition = lockedAxes.Apply(target.position, transform.position);
            transform.position = snappedPosition;
        }

        initialPosition = transform.position;
        offset = transform.position - target.position;
    }
    
    private void LateUpdate() 
    {
        Vector3 desiredPosition = target.position + offset;
        desiredPosition = lockedAxes.Apply(desiredPosition, initialPosition);

        transform.position = Vector3.Lerp(transform.position, desiredPosition, speed * Time.deltaTime);
    }
}
