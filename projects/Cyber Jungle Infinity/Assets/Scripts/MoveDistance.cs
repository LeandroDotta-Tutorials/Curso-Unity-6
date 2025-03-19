using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AutoMovement))]
public class MoveDistance : MonoBehaviour
{
    public float distance = 3;

    private void OnBecameVisible()
    {
        StartCoroutine(MoveDistanceCoroutine());
    }

    private IEnumerator MoveDistanceCoroutine()
    {
        float distanceTraveled = 0;

        while (distanceTraveled < distance)
        {
            float currentPostionY = transform.position.y;

            yield return null;

            distanceTraveled += Mathf.Abs(currentPostionY - transform.position.y);
        }

        SendMessage("OnDistanceReached");
    }
}
