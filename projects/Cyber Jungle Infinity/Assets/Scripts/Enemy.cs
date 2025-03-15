using System;
using System.Collections;
using UnityEngine;

public enum EnemyAction
{
    Idle, Shoot, Sway, 
}

[Serializable]
public struct EnemyState
{
    public EnemyAction[] actions;
    public float duration;
}

public class Enemy : MonoBehaviour
{
    public EnemyState[] states;

    [Header("Sound Effects")]
    public SoundEffect soundShoot;
    public SoundEffect soundLoose;
    public SoundEffect soundDamage;

    private AutoMovement autoMovement;
    private SwayMovement swayMovement;
    private MoveDistance moveDistance;
    private Gun gun;
    private Animator anim;
    private Collider2D coll;
    private SoundEffectPlayer soundEffectPlayer;

    private void Start()
    {
        autoMovement = GetComponent<AutoMovement>();
        swayMovement = GetComponent<SwayMovement>();
        moveDistance = GetComponent<MoveDistance>();
        gun = GetComponentInChildren<Gun>();
        anim = GetComponent<Animator>();
        coll = GetComponent<Collider2D>();
        soundEffectPlayer = new SoundEffectPlayer(GetComponent<AudioSource>());

        anim.SetBool("moving", true);
        anim.SetBool("attacking", false);
    }

    private void OnDestroy()
    {
        SendMessageUpwards("OnEnemyDestroyed", this);    
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out HealthManager healthManager))
        {
            healthManager.Damage(1);
            Destroy(gameObject);
        }
    }

    private void OnHealthChange(int health)
    {
        if (health == 0)
        {
            Loose();
            return;
        }

        anim.SetTrigger("take_damage");
        soundEffectPlayer.Play(soundDamage);
    }

    private void OnDistanceReached()
    {
        StartCoroutine(RunStatesCoroutine());
    }

    private void OnShoot()
    {
        anim.SetTrigger("shoot");
        soundEffectPlayer.Play(soundShoot);
    }

    private IEnumerator RunStatesCoroutine()
    {
        anim.SetBool("moving", false);
        anim.SetBool("attacking", true);
        anim.SetTrigger("turn");

        foreach (var state in states)
        {
            StartState(state);
            yield return new WaitForSeconds(state.duration);
            EndState(state);
        }

        anim.SetBool("moving", true);
    }

    private void StartState(EnemyState state)
    {
        foreach (var action in state.actions)
        {
            switch (action)
            {
                case EnemyAction.Idle:
                    autoMovement.enabled = false;
                    break;
                case EnemyAction.Shoot:
                    gun.enabled = true;
                    break;
                case EnemyAction.Sway:
                    swayMovement.enabled = true;
                    break;
            }
        }
    }

    private void EndState(EnemyState state)
    {
        foreach (var action in state.actions)
        {
            switch (action)
            {
                case EnemyAction.Idle:
                    autoMovement.enabled = true;
                    break;
                case EnemyAction.Shoot:
                    gun.enabled = false;
                    break;
                case EnemyAction.Sway:
                    swayMovement.enabled = false;
                    break;
            }
        }
    }

    private void Loose()
    {
        StopAllCoroutines();
        anim.SetTrigger("explode");
        soundEffectPlayer.Play(soundLoose);

        coll.enabled = false;
        gun.enabled = false;
        swayMovement.enabled = false;
        autoMovement.enabled = true;

        Destroy(moveDistance);
        Invoke("DestroySelf", 2);
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
