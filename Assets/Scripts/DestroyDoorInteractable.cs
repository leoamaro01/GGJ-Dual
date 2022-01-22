using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDoorInteractable : InteractableObject
{
    public PlayerController player;

    public override bool IsInteractable => player.state;
}
