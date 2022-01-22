using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperElevator : MonoBehaviour
{
    public StarterAssets.FirstPersonController firstPersonController;
    public Cinemachine.CinemachineVirtualCamera shakeCamera;
    public Cinemachine.CinemachineVirtualCamera daiCamera;
    float defaultMoveSpeed;
    public Transform playerRebornPlaceholder;
    public void GoDown()
    {
        defaultMoveSpeed = firstPersonController.MoveSpeed;
        firstPersonController.MoveSpeed = 0;
        firstPersonController.SprintSpeed = 0;
    }
    public void BreakDown()
    {
        shakeCamera.Priority = 2;
    }
    public void PlayerDai()
    {
        shakeCamera.Priority = 0;
        daiCamera.Priority = 2;
    }
    public void PlayerLif()
    {
        firstPersonController.transform.position = playerRebornPlaceholder.position;
        daiCamera.Priority = 0;
        firstPersonController.MoveSpeed = defaultMoveSpeed;
        firstPersonController.SprintSpeed = defaultMoveSpeed;
    }
}
