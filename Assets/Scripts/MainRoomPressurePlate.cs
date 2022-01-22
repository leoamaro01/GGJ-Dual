using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainRoomPressurePlate : MonoBehaviour
{
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

        exitDoorAnimator.SetBool("IsOpen", true);
    }
    public void OnExit()
    {
        exitDoorAnimator.SetBool("IsOpen", false);
    }
}
