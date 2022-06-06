using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBinTeleport : MonoBehaviour
{
    private BoxCollider boxCol;

    public GameObject TrashBin;
    public GameObject Trigger;

    public AudioSource PlaceObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trash"))
        {
            Debug.Log("Trigger!");

            TrashBin.transform.parent = null;
            TrashBin.transform.rotation = Quaternion.identity;
            TrashBin.transform.position = new Vector3(74.3700027f, -6.50899982f, 27.5550003f);
            PlaceObject.Play();

            boxCol = TrashBin.GetComponent<BoxCollider>();
            boxCol.enabled = !boxCol.enabled;

            Trigger.SetActive(false);
        }
    }
}
