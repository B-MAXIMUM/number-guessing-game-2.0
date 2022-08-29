using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{
    public void LoadNextScene()
    {
      int currentSceneIndex = SceneManager.GetActiveScene().buildIndex; 
      SceneManager.LoadScene(currentSceneIndex + 1);
    }

    // Update is called once per frame
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}