using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    const float MIN_MOVE_SPEED = 1f;
    public PlayerController controller;
    public StarterAssets.FirstPersonController firstPersonController;
    public AudioSource sprintAudioSource;
    public AudioSource walkAudioSource;

    void Start()
    {
        walkAudioSource.Stop();
        sprintAudioSource.Stop();
    }
    void Update()
    {
        float speed = firstPersonController.GetCurrentSpeed();
        if (speed < MIN_MOVE_SPEED)
        {
            walkAudioSource.Stop();
            sprintAudioSource.Stop();
            return;
        }

        if (controller.state)
        {
            walkAudioSource.Stop();
            if (!sprintAudioSource.isPlaying)
                sprintAudioSource.Play();
        }
        else
        {
            if (!walkAudioSource.isPlaying)
                walkAudioSource.Play();
            sprintAudioSource.Stop();
        }
    }
}
