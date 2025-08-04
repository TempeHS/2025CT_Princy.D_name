using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject WinScreen;
    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.SetActive(false);
        WinScreen.SetActive(false);
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void Win()
    {
        WinScreen.SetActive(true);
    }
}
