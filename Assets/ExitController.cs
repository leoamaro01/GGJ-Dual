using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitController : MonoBehaviour
{
    int frozenPistons = 0;
    public GameObject pressurePlate;
    public Collider exitBlocker;
    public Animator exitDoorAnim;
    public GameObject gameOverTrigger;
    public Cinemachine.CinemachineVirtualCamera gameOverCamera;
    public StarterAssets.FirstPersonController firstPersonController;

    public void FreezePiston()
    {
        frozenPistons++;

        if(frozenPistons == 2)
        {
            pressurePlate.SetActive(false);
            exitDoorAnim.SetBool("IsOpen", true);
            exitBlocker.enabled = false;
            gameOverTrigger.SetActive(true);
        }
    }
    public void GameOver()
    {
        gameOverCamera.Priority = 2;
        firstPersonController.MoveSpeed = 0;
        firstPersonController.SprintSpeed = 0;
    }
}
