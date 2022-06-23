using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampTeleport : MonoBehaviour
{
    private BoxCollider boxCol;
    private BoxCollider boxColx;

    public Camera cam;

    public GameObject Lamp;
    public GameObject Trigger;
    public GameObject ItemCamera;
    public GameObject Crosshair;
    public GameObject NextObjectInteractable;
    public GameObject BaseObject;

    public AudioSource PlaceObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lamp"))
        {
            //Debug.Log("Picked Up!");

            Lamp.transform.parent = null;
            Lamp.transform.rotation = Quaternion.Euler(0, 0, 0);
            Lamp.transform.localPosition = new Vector3(24.7609997f, -4.95100021f, -12.5120001f);
            PlaceObject.Play();

            boxCol = Lamp.GetComponent<BoxCollider>();
            boxCol.enabled = !boxCol.enabled;

            Trigger.SetActive(false);
            ItemCamera.SetActive(false);
            Crosshair.SetActive(true);

            cam.cullingMask = -1;
            cam.cullingMask &= ~(1 << LayerMask.NameToLayer("Chair"));

            NextObjectInteractable.SetActive(true);

            boxColx = NextObjectInteractable.GetComponent<BoxCollider>();
            boxColx.enabled = true;

            BaseObject.SetActive(false);
        }
    }
}
