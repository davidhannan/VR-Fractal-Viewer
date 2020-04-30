using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fractalSelect : MonoBehaviour
{
    public void loadFractal(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void exit()
    {
        Application.Quit();
    }
}
