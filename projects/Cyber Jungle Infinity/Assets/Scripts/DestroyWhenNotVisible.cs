using UnityEngine;

public class DestroyWhenNotVisible : MonoBehaviour
{
    private void OnBecameInvisible()
    {        
        Debug.Log($"DestroyWhenNotVisible: {gameObject.name}");
        Destroy(gameObject);
    }
}