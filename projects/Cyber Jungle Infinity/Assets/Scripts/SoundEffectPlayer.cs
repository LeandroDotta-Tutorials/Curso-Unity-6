using System;
using UnityEngine;

[Serializable]
public struct SoundEffect
{
    public AudioClip clip;
    [Range(0, 1)] public float volume;
}

public class SoundEffectPlayer
{
    private AudioSource audioSource;

    public SoundEffectPlayer(AudioSource audioSource)
    {
        this.audioSource = audioSource;
    }

    public void Play(SoundEffect sound)
    {
        audioSource.PlayOneShot(sound.clip, sound.volume);
    }
}
