using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainRoomPressurePlate : MonoBehaviour
{
    public AudioSource pressurePlateAudioSource;
    public Animator exitDoorAnimator;
    public Animator backDoorAnimator;
    bool firstTrigger = true;

    public void OnEnter()
    {
        if (firstTrigger)
        {
            backDoorAnimator.SetTrigger("Open");
            firstTrigger = false;
        }

        pressurePlateAudioSource.Stop();
        pressurePlateAudioSource.Play();

        exitDoorAnimator.SetBool("IsOpen", true);
    }
    public void OnExit()
    {
        exitDoorAnimator.SetBool("IsOpen", false);
    }
}
