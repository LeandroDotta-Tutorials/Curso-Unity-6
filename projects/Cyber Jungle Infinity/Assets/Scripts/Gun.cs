using UnityEngine;

public class Gun : MonoBehaviour
{
    public float speed = 5;
    public float interval = 0.5f;
    public Vector2 direction = Vector2.up;
    public string targetTag;
    public Projectile projectilePrefab;

    private void OnEnable() 
    {
        InvokeRepeating(nameof(SpawnProjectile), interval, interval);    
    }

    private void OnDisable() 
    {
        CancelInvoke(nameof(SpawnProjectile));
    }

    public void SpawnProjectile()
    {
        Projectile projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        projectile.targetTag = targetTag;

        AutoMovement projectileMovement = projectile.GetComponent<AutoMovement>();
        projectileMovement.speed = speed;
        projectileMovement.direction = direction;

        SendMessageUpwards("OnShoot", projectile, SendMessageOptions.DontRequireReceiver);
    }
}
