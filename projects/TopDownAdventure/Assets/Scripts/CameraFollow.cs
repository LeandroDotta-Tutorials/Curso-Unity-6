using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Target to Follow")]
    [SerializeField] private Transform target;

    [Header("Follow Settings")]
    [SerializeField] private float speed = 5f;

    [Tooltip("Controls the smoothing of the follow.")]
    [SerializeField] private AnimationCurve smoothCurve = AnimationCurve.EaseInOut(0, 0, 1, 1);

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 currentPos = transform.position;
        Vector3 targetPos = new(target.position.x, target.position.y, currentPos.z);

        // float t = smoothCurve.Evaluate(Mathf.Clamp01(speed * Time.deltaTime));
        // transform.position = Vector3.Lerp(currentPos, targetPos, t);
        transform.position = targetPos;
    }
}
