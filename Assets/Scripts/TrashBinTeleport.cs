using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBinTeleport : MonoBehaviour
{
    private BoxCollider boxCol;
    private BoxCollider boxColLamp;

    public Camera cam;

    public GameObject TrashBin;
    public GameObject Trigger;
    public GameObject ItemCamera;
    public GameObject Crosshair;
    public GameObject NextObject;

    public AudioSource PlaceObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trash"))
        {
            //Debug.Log("Picked Up!");

            TrashBin.transform.parent = null;
            TrashBin.transform.rotation = Quaternion.identity;
            TrashBin.transform.position = new Vector3(74.3700027f, -6.50899982f, 27.5550003f);
            PlaceObject.Play();

            boxCol = TrashBin.GetComponent<BoxCollider>();
            boxCol.enabled = !boxCol.enabled;

            Trigger.SetActive(false);
            ItemCamera.SetActive(false);
            Crosshair.SetActive(true);

            NextObject.transform.localPosition = new Vector3(-48.7509995f, -0.966000021f, -4.33400011f);
            NextObject.transform.rotation = Quaternion.Euler(340.670197f, 90, 270);

            boxColLamp = NextObject.GetComponent<BoxCollider>();
            boxColLamp.enabled = true;

            //cam.cullingMask = -1;
        }
    }
}
