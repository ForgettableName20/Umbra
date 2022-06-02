using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightSwitchRaycast : MonoBehaviour
{
    [SerializeField] private int rayLength = 5;
    private LightSwitch interactiveObj;

    [SerializeField] private RawImage crosshair;

    public Color CrosshairColor = new Color(103, 179, 80);
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
                CrosshairChange(true);
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
            CrosshairChange(false);
            interactiveObj = null;
        }
    }

    void CrosshairChange(bool on)
    {
        if (on)
        {
            crosshair.color = CrosshairColor;
            interactPrompt.SetActive(true);

        }
        else
        {
            crosshair.color = Color.white;
            interactPrompt.SetActive(false);
        }
    }
}
