using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public void Start()
    {
        Invoke("Setup", 2);
    }

    public void Setup()
    {
        SceneManager.LoadScene(2);
    }

    public void restart()
    {
        SceneManager.LoadScene(1);
    }
    public void exit()
    {
        Application.Quit();
    }
}
