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
// Testing scripts 
    public void RetryGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void QuitGame()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void ContinueGame()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void NextLevel()
    {
        SceneManager.LoadSceneAsync(3);
    }

}


// MainMenu.PlayGame

