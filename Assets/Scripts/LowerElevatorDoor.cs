using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerElevatorDoor : MonoBehaviour
{
    public AudioSource source;
    public AudioClip bangClip;
    public Animator animator;
    public void PlayDoorBang()
    {
        if (animator.IsInTransition(0))
            return;
        source.pitch = Random.Range(0.8f, 1.2f);
        source.PlayOneShot(bangClip);
    }
}
