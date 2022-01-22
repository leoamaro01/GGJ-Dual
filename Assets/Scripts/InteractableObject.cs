using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    public string interactionText;
    public UnityEvent onInteract;
    public virtual bool IsInteractable => true;
}
