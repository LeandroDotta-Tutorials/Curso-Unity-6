using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Sound Effects")]
    public SoundEffect soundShot;
    // public AudioClip soundShot;
    public SoundEffect soundDamage;
    public SoundEffect soundLoose;

    private Animator animator;
    private Collider2D coll;
    private PlayerController controller;
    private Gun gun;
    private GameManager gameManager;
    private SoundEffectPlayer soundEffectPlayer;


    private void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        coll = GetComponent<Collider2D>();
        soundEffectPlayer = new SoundEffectPlayer(GetComponent<AudioSource>());
        animator = GetComponent<Animator>();
        controller = GetComponent<PlayerController>();
        gun = GetComponentInChildren<Gun>();
    }

    private void OnDisable()
    {
        coll.enabled = false;
        gun.enabled = false;
        controller.enabled = false;
    }

    private void Update()
    {
        UpdateAnimations(controller.direction);
    }

    private void UpdateAnimations(Vector2 direction)
    {
        animator.SetFloat("direction_horizontal", direction.x);
        animator.SetFloat("direction_vertical", direction.y);
    }

    private void OnHealthChange(int health)
    {
        if (health == 0)
        {
            Loose();
            return;
        }

        animator.SetTrigger("take_damage");
        soundEffectPlayer.Play(soundDamage);
    }

    private void OnInvulnerableStart()
    {
        animator.SetBool("blinking", true);
    }

    private void OnInvulnerableEnd()
    {
        animator.SetBool("blinking", false);
    }

    private void OnShoot()
    {
        soundEffectPlayer.Play(soundShot);
    }

    private void Loose()
    {
        enabled = false;
        animator.SetTrigger("explode");
        soundEffectPlayer.Play(soundLoose);
        Invoke("ShowGameOver", 2f);
    }

    private void ShowGameOver()
    {
        gameManager.GameOver();
    }
}
