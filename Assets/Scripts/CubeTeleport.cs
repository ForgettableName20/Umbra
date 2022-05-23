using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTeleport : MonoBehaviour
{
    [SerializeField] private Vector3[] randomPosition;

    private int currentPosition = 0;

    public void Teleport()
    {
        transform.position = randomPosition[currentPosition++];
        currentPosition = currentPosition == randomPosition.Length ? 0 : currentPosition;
    }
}
