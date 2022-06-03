using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{  
    public void exitGame()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
