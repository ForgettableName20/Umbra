using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelchairTeleport : MonoBehaviour
{
    private BoxCollider boxCol;

    public GameObject ObjectPlaced;
    public GameObject ObjectHolded;
    public GameObject Trigger;

    public Animator exitDoorAnim = null;

    public AudioSource PortalSound;
    public AudioSource DoorSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wheelchair"))
        {
            //Debug.Log("Trigger");

            ObjectPlaced.SetActive(true);
            ObjectHolded.SetActive(false);
            Trigger.SetActive(false);

            boxCol = ObjectPlaced.GetComponent<BoxCollider>();
            boxCol.enabled = !boxCol.enabled;

            PortalSound.Play();
            DoorSound.Play();

            exitDoorAnim.Play("ExitDoor", 0, 0.0f);
        }
    }
}
