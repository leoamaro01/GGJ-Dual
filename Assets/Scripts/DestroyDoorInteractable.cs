using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDoorInteractable : InteractableToggle
{
    public PlayerController player;

    public override bool IsInteractable => player.state && base.IsInteractable;
}
