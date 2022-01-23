using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeDoorInteractable : InteractableToggle
{
    public PlayerController player;

    public override bool IsInteractable => !player.state && base.IsInteractable;
}
