using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private AutoMovement autoMovement;

    private void Start() 
    {
        autoMovement = GetComponent<AutoMovement>();
        StartCoroutine(MoveDistanceCoroutine(3));
    }

    private IEnumerator MoveDistanceCoroutine(float distance)
    {
        float distanceTraveled = 0;
        autoMovement.enabled = true;

        while (distanceTraveled < distance)
        {
            float currentPostionY = transform.position.y;

            yield return null;

            distanceTraveled += Mathf.Abs(currentPostionY - transform.position.y);
            Debug.Log($"Distance Traveled: {distanceTraveled}");
        }


        StartCoroutine(IdleCoroutine());
    }

    private IEnumerator IdleCoroutine()
    {
        autoMovement.enabled = false;
        yield return new WaitForSeconds(5);
        autoMovement.enabled = true;
    }
}
