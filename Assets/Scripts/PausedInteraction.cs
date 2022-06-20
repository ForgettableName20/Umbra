using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausedInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    public void GamePaused()
    {
        Time.timeScale = 0f;
    }

    public void GameUnpaused()
    {
        Time.timeScale = 1f;
    }
}
