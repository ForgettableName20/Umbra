using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Options()
    {

    }

    public void QuitGame()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Quit");
        Application.Quit();
    }

}
