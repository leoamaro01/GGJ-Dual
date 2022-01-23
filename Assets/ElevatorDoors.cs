using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoors : MonoBehaviour
{
    public AudioSource elevatorAudioSource;
    public void ChangeState()
    {
        elevatorAudioSource.Play();
    }
}
