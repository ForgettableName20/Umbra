using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public GameObject Player;
    public GameObject FloorOff;
    public GameObject FloorOn;
    public GameObject Trigger;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Trigger!");
            //Player.transform.position = new Vector3(75.9700012f, -11.6300001f, 23.1499996f);
            Player.transform.rotation = Quaternion.Euler(0, 184.343918f, 0);
            FloorOff.SetActive(false);
            FloorOn.SetActive(true);
            Trigger.SetActive(false);
        }
    }
}
