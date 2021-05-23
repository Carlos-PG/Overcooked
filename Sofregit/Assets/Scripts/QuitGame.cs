using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("exiting game");
        Application.Quit();                     // for build
       // EditorApplication.isPlaying = false;    // for editor
    }
}
