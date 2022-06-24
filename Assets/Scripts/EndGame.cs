using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered!");

        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
        }
    }
}
