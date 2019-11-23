using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    // Start is called before the first frame update
     public void StartPlay()
    {
        SceneManager.LoadScene("Main");
        
    }

    public void StopPlaying()
    {
        SceneManager.LoadScene("Exit");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Intro");
    }

    public void ExitGame()
    {
        // exit the game for real play
        //Application.Quit();
        //does not work in Unity since it would  lose all settings. so:
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
