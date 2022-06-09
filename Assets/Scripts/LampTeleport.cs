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
    public GameObject NextObject;

    public AudioSource PlaceObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lamp"))
        {
            Debug.Log("Trigger!");

            Lamp.transform.parent = null;
            Lamp.transform.rotation = Quaternion.Euler(-90, 90, -90);
            Lamp.transform.localPosition = new Vector3(24.868f, -5.11000013f, -12.467f);
            PlaceObject.Play();

            boxCol = Lamp.GetComponent<BoxCollider>();
            boxCol.enabled = !boxCol.enabled;

            Trigger.SetActive(false);
            ItemCamera.SetActive(false);
            Crosshair.SetActive(true);

            NextObject.transform.localPosition = new Vector3(-48.7509995f, -0.933000028f, -4.33400011f);
            NextObject.transform.rotation = Quaternion.Euler(338.401611f, 90f, 270f);

            boxColx = NextObject.GetComponent<BoxCollider>();
            boxColx.enabled = true;

            cam.cullingMask = -1;


        }
    }
}
