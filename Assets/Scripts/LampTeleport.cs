using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampTeleport : MonoBehaviour
{
    public GameObject Lamp;
    public GameObject Trigger;

    public AudioSource PlaceObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lamp"))
        {
            Debug.Log("Trigger!");
            Lamp.transform.parent = null;
            Lamp.transform.rotation = Quaternion.identity;
            Lamp.transform.position = new Vector3(74.3700027f, 0.0240000002f, 27.5550003f);
            PlaceObject.Play();
            Trigger.SetActive(false);
        }
    }
}
