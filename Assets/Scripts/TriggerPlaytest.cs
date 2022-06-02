using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlaytest : MonoBehaviour
{
    public GameObject Trigger;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Trigger.SetActive(true);
        }
    }
}
