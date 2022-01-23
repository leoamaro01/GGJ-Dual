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
    public StarterAssets.FirstPersonController firstPersonController;
    public GameObject gameOverScreen;

    PlayerControls controls;

    void Awake()
    {
        if (controls == null)
        {
            controls = new PlayerControls();
            controls.Enable();
        }

        controls.Player.Dai.performed += ctx =>
        {
            if (over)
                Application.Quit();
        };
    }
    public void FreezePiston()
    {
        frozenPistons++;

        if (frozenPistons == 2)
        {
            pressurePlate.SetActive(false);
            exitDoorAnim.SetBool("IsOpen", true);
            exitBlocker.enabled = false;
            gameOverTrigger.SetActive(true);
        }
    }
    bool over = false;
    public void GameOver()
    {
        over = true;
        firstPersonController.MoveSpeed = 0;
        firstPersonController.SprintSpeed = 0;
        gameOverScreen.SetActive(true);
    }
}
