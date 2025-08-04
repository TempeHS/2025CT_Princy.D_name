using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void RetryGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void QuitGame()
    {
        SceneManager.LoadSceneAsync(0);
    }

}


// MainMenu.PlayGame

