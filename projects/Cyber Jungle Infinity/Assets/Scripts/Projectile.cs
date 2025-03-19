using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage = 1;
    public string targetTag;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (!other.CompareTag(targetTag))
        {
            return;
        }

        if (other.TryGetComponent(out HealthManager healthManager))
        {
            healthManager.Damage(damage);
            Destroy(gameObject);
        }
    }
}
