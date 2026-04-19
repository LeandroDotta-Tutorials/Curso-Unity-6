using UnityEngine;

public class PackageCollectible : MonoBehaviour
{
    public Transform packageTransform;

    public void Remove()
    {
        // TODO: Play animation, disable colliders, and destroy the gameobject after the animation
        Destroy(gameObject);
    }

    private void OnReset() 
    {
        Package package = GetComponentInChildren<Package>();
        if (package != null) packageTransform = package.transform;
    }
}
