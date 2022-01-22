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

    public void Awake()
    {
        ChangeState(state);
    }
    public void ChangeState(bool newState)
    {
        state = newState;
        if (newState)
        {
            annaCam.Priority = 0;
            ivanCam.Priority = 1;
        }
        else
        {
            annaCam.Priority = 1;
            ivanCam.Priority = 0;
        }
    }

}
