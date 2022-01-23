using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerController : MonoBehaviour
{
    // true for Ivan, false for Anna
    public bool state;
    public CinemachineVirtualCamera annaCam;
    public CinemachineVirtualCamera ivanCam;
    public Animator handAnimator;
    public Animator hudAnimator;
    public AudioSource madnessAudioSource;
    public AudioSource freezeAudioSource;

    public float ivanSpeed;
    public float annaSpeed;

    public StarterAssets.FirstPersonController mover;

    public void Awake()
    {
        ChangeState(state);
    }
    public void ChangeState(bool newState)
    {
        state = newState;
        hudAnimator.SetBool("Status", newState);
        if (newState)
        {
            annaCam.Priority = 0;
            ivanCam.Priority = 1;

            mover.MoveSpeed = ivanSpeed;
            mover.SprintSpeed = ivanSpeed;
        }
        else
        {
            annaCam.Priority = 1;
            ivanCam.Priority = 0;

            mover.MoveSpeed = annaSpeed;
            mover.SprintSpeed = annaSpeed;
        }
    }

    public void Freeze()
    {
        freezeAudioSource.Stop();
        freezeAudioSource.Play();

        handAnimator.SetTrigger("Freeze");
    }
    public void GoMad()
    {
        madnessAudioSource.Stop();
        madnessAudioSource.Play();

        handAnimator.SetTrigger("GoMad");
    }
    public void Power()
    {
        handAnimator.SetTrigger("Power");
    }
}

