using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairTeleport : MonoBehaviour
{
    private BoxCollider boxCol;

    public GameObject ObjectPlaced;
    public GameObject ObjectHolded;
    public GameObject Trigger;

    public AudioSource PlaceObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Chair"))
        {
            Debug.Log("Trigger");

            ObjectPlaced.SetActive(true);
            ObjectHolded.SetActive(false);
            Trigger.SetActive(false);

            boxCol = ObjectPlaced.GetComponent<BoxCollider>();
            boxCol.enabled = !boxCol.enabled;

            PlaceObject.Play();
        }
    }
}
