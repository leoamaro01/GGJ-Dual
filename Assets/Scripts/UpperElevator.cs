using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperElevator : MonoBehaviour
{
    public StarterAssets.FirstPersonController firstPersonController;
    public Cinemachine.CinemachineVirtualCamera shakeCamera;
    public Cinemachine.CinemachineVirtualCamera daiCamera;
    float defaultMoveSpeed;
    public Transform playerLifPlaceholder;
    public Animator lowerElevatorDoors;
    public Animator upperElevatorDoors;
    public void StartMoving()
    {
        firstPersonController.transform.SetParent(transform);
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
        daiCamera.Priority = 3;
        shakeCamera.Priority = 0;
    }
    public void Returned()
    {
        firstPersonController.transform.SetParent(null);
        firstPersonController.MoveSpeed = defaultMoveSpeed;
        firstPersonController.SprintSpeed = defaultMoveSpeed;

        upperElevatorDoors.SetTrigger("ChangeState");
    }
    public void PlayerLif()
    {
        firstPersonController.transform.SetParent(null);
        firstPersonController.transform.position = playerLifPlaceholder.position;
        daiCamera.Priority = 0;
        firstPersonController.MoveSpeed = defaultMoveSpeed;
        firstPersonController.SprintSpeed = defaultMoveSpeed;

        lowerElevatorDoors.SetTrigger("ChangeState");
    }
}
