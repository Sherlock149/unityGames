using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Management : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("scene0");
    }
    public void Replay()
    {
        SceneManager.LoadScene("scene0");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
