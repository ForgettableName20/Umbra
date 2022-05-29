using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TriggerOpenDoor : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private GameObject Trigger;

    public AudioSource Unlock;

    private void OnTriggerEnter (Collider other)
    {
        Debug.Log("Triggered!");

        if (other.CompareTag("Player"))
        {
            myDoor.Play("DoorOpen", 0, 0.0f);
            Unlock.Play();
            Trigger.SetActive(false);
        }
    }

    /*
    private void OnTriggerExit (Collider other)
    {
        if (other.CompareTag("Player"))
        {   
            myDoor.Play("DoorClose", 0, 0.0f);
        }
    }
    */
}
