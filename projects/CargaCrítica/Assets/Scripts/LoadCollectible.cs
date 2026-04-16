using UnityEngine;

public class LoadCollectible : MonoBehaviour
{
    public Transform loadModel;

    public void Remove()
    {
        // TODO: Play animation, disable colliders, and destroy the gameobject after the animation
        Destroy(gameObject);
    }
}
