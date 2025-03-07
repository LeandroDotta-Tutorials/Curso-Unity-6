using System.Collections;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int startHealth = 1;
    public int maxHealth = 1;
    public float invulnerableInterval = 1;
    public HealthBar healthBar;

    public int Health { get; private set; }

    private bool isInvulnerable = false;

    private void Start()
    {
        Health = startHealth;
    }

    public void Damage(int amount)
    {
        if (isInvulnerable)
            return;

        Health -= amount;

        if (Health < 0)
        {
            Health = 0;
        }

        SendMessage("OnHealthChange", Health, SendMessageOptions.RequireReceiver);
        healthBar?.SetHealth(Health);

        if (invulnerableInterval <= 0 || Health <= 0)
            return;
            
        StartCoroutine(InvulnerableCoroutine());
    }

    public void Heal(int amount)
    {
        Health += amount;

        if (Health > maxHealth)
        {
            Health = maxHealth;
        }

        SendMessage("OnHealthChange", Health, SendMessageOptions.RequireReceiver);
        healthBar?.SetHealth(Health);
    }

    private IEnumerator InvulnerableCoroutine()
    {
        isInvulnerable = true;
        SendMessage("OnInvulnerableStart", SendMessageOptions.DontRequireReceiver);

        yield return new WaitForSeconds(invulnerableInterval);

        isInvulnerable = false;
        SendMessage("OnInvulnerableEnd", SendMessageOptions.DontRequireReceiver);
    }
}
