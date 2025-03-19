using UnityEngine;

public class DestroyWhenNotVisible : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}