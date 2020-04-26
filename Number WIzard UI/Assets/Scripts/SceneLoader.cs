using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        EventSystem.current.SetSelectedGameObject(null);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        EventSystem.current.SetSelectedGameObject(null);
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        EventSystem.current.SetSelectedGameObject(null);
        Application.Quit();
    }
}
