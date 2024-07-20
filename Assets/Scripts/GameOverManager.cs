using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject quitConfirmationUI;

    void Start()
    {
        gameOverUI.SetActive(false);
        quitConfirmationUI.SetActive(false);
    }

    public void ShowGameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0); // Ana men� sahnesinin build index numaras�n� kullan
    }

    public void QuitGame()
    {
        quitConfirmationUI.SetActive(true);
    }

    public void ConfirmQuit(bool isQuitting)
    {
        if (isQuitting)
        {
            Application.Quit();
        }
        else
        {
            quitConfirmationUI.SetActive(false);
        }
    }
}

