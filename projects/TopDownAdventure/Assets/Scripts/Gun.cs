using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float cooldown;
    public LayerMask ignoreLayers;
    [SerializeField] private Projectile projectilePrefab;

    private float cooldownTimer;
    public bool IsCoolingDown { get => cooldownTimer > 0; }

    private void Start()
    {
        ResetCooldownTimer();
    }

    private void Update()
    {
        if (IsCoolingDown)
        {
            cooldownTimer -= Time.deltaTime;
        }
    }

    public void Shoot(Vector2 direction)
    {
        if (IsCoolingDown) return;

        Projectile projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        projectile.ignoreLayers = ignoreLayers;
        projectile.Direction = direction;
        ResetCooldownTimer();
    }

    private void ResetCooldownTimer()
    {
        cooldownTimer = cooldown;
    }
}
