using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    const int SEMI_UPDATE_FPS = 10;
    const float SEMI_UPDATE_MS = 1000f / SEMI_UPDATE_FPS;

    public float interactionDistance;
    public Camera cam;
    public TMP_Text interactionLabel;

    private PlayerControls controls;
    private InteractableObject interactable;
    private void Awake()
    {
        if (controls == null)
        {
            controls = new PlayerControls();
            controls.Enable();
        }

        controls.Player.Interact.performed += OnInteract;
        StartCoroutine(SemiUpdate());
    }
    private void OnInteract(InputAction.CallbackContext ctx)
    {
        if (interactable != null)
        {
            if (interactable.onInteract != null)
                interactable.onInteract.Invoke();
        }
    }
    private IEnumerator SemiUpdate()
    {
        while (true)
        {
            bool canInteract = false;
            Ray camRay = cam.ViewportPointToRay(Vector3.one / 2);
            if (Physics.Raycast(camRay, out RaycastHit hitInfo, interactionDistance))
            {
                interactable = hitInfo.transform.GetComponent<InteractableObject>();
                if (interactable != null && interactable.IsInteractable)
                {
                    canInteract = true;
                    interactionLabel.text = interactable.interactionText;
                }
                else
                    interactable = null;
            }

            if (!canInteract)
                interactionLabel.text = "";

            yield return new WaitForSecondsRealtime(SEMI_UPDATE_MS / 1000f);
        }
    }
}
