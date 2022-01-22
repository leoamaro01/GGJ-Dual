using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableToggle : InteractableObject
{
    [SerializeField]
    private bool canInteract;
    public bool CanInteract { get => canInteract; set { canInteract = value; } }
    public override bool IsInteractable => CanInteract;
}
