using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashBinTeleport : MonoBehaviour
{
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
            TrashBin.transform.position = new Vector3(74.3700027f, 0.0240000002f, 27.5550003f);
            PlaceObject.Play();
            Trigger.SetActive(false);
        }
    }
}
