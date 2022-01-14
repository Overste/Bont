using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public static void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public static void LoadSceneBySceneName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public static void LoadNextScene()
    {
        // todo make fix length problem
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
