using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class SceneChanger : MonoBehaviour
{
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ToOptions()
    {
        SceneManager.LoadScene("Options");
    }
    public void ToGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    public void ReplayGame()
    {
        Score.Lives = 5;
        SceneManager.LoadScene("Main");
    }

}
