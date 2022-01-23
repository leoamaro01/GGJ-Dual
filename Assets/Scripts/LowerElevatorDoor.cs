using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class LowerElevatorDoor : MonoBehaviour
{
    public AudioSource source;
    public AudioClip bangClip;
    public Animator animator;
    public InteractableToggle interactable;
    public GameObject protector;
    public void PlayDoorBang()
    {
        if (animator.IsInTransition(0))
            return;
        source.pitch = Random.Range(0.8f, 1.2f);
        source.PlayOneShot(bangClip);
    }
    public void Freeze()
    {
        interactable.CanInteract = false;
        interactable.gameObject.SetActive(false);
        animator.SetBool("IsFrozen", true);
        StartCoroutine(RemoveProtection());
    }
    public void Unfreeze()
    {
        protector.SetActive(true);
        animator.SetBool("IsFrozen", false);
        StartCoroutine(PlaceProtection());
    }
    IEnumerator PlaceProtection()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        yield return new WaitUntil(() => !animator.IsInTransition(0));

        interactable.gameObject.SetActive(true);
        interactable.CanInteract = true;
    }
    IEnumerator RemoveProtection()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        yield return new WaitUntil(() => !animator.IsInTransition(0));

        protector.SetActive(false);
    }
}
