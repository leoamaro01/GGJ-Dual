using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorButtons : MonoBehaviour
{
    bool isUp = true;
    public Animator elevatorAnimator;
    public Animator upperDoorsAnimator;
    public Animator lowerDoorsAnimator;

    public void Interact()
    {
        isUp = !isUp;
        elevatorAnimator.SetTrigger("Move");

        if(isUp)
        {
            lowerDoorsAnimator.SetTrigger("ChangeState");
        }
        else
        {
            upperDoorsAnimator.SetTrigger("ChangeState");
        }
    }
}
