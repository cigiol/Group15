using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    // UI öðelerini referanslamak için deðiþkenler
    public Text gameOverText;
    public Button RestartButton;
    public Button MainMenuButton;
    public Button QuitButton;
    // QuitPanelScript'e referans
    public QuitPanel QuitPanel;

    // Oyun bittiðinde çalýþtýrýlacak fonksiyon
    public void GameOver()
    {
        // Oyun bittiðini gösteren metni etkinleþtir
        gameOverText.gameObject.SetActive(true);

        // Düðmeleri etkinleþtir
        RestartButton.gameObject.SetActive(true);
        MainMenuButton.gameObject.SetActive(true);
        QuitButton.gameObject.SetActive(true);

        // Oyunu durdur
        Time.timeScale = 0f;


        // QuitPanel'i göster
        QuitPanel.ShowQuitPanel();
    }

    // Restart düðmesine týklandýðýnda çalýþtýrýlacak fonksiyon
    public void RestartGame()
    {
        // Oyun sahnesini yeniden yükle
        SceneManager.LoadScene(1);

        // Oyunu yeniden baþlat
        Time.timeScale = 1f;
    }

    // Ana Menü düðmesine týklandýðýnda çalýþtýrýlacak fonksiyon
    public void GoToMainMenu()
    {
        // Ana Menü sahnesini yükle
        SceneManager.LoadScene(0);

        // Oyunu yeniden baþlat
        Time.timeScale = 1f;
    }

    // Çýkýþ düðmesine týklandýðýnda çalýþtýrýlacak fonksiyon
    public void QuitGame()
    {
        // Uygulamadan çýk
        Application.Quit();
    }
}
