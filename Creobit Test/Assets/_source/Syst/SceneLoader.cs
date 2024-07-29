using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadClicker()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadWalker()
    {
        SceneManager.LoadScene(2);
    }
}
