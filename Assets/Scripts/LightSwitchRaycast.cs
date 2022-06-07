using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightSwitchRaycast : MonoBehaviour
{
    [SerializeField] private int rayLength = 5;
    private LightSwitch interactiveObj;

    public GameObject interactPrompt;

    private void Update()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if(Physics.Raycast(transform.position, fwd, out RaycastHit hit, rayLength))
        {
            var raycastObj = hit.collider.gameObject.GetComponent<LightSwitch>();
            if(raycastObj != null)
            {
                interactiveObj = raycastObj;
                PromptChange(true);
            }
            else
            {
                ClearInteraction();
            }
        }
        else
        {
            ClearInteraction();
        }
        if (interactiveObj != null)
        {
            if(Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.F))
            {
                interactiveObj.InteractSwitch();
            }
        }
    }

    private void ClearInteraction()
    {
        if(interactiveObj != null)
        {
            PromptChange(false);
            interactiveObj = null;
        }
    }

    void PromptChange(bool on)
    {
        if (on)
        {
            interactPrompt.SetActive(true);
        }
        else
        {
            interactPrompt.SetActive(false);
        }
    }
}
