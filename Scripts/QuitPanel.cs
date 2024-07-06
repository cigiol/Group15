using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuitPanel : MonoBehaviour
{
    // UI öðelerini referanslamak için deðiþkenler
    public Text QuitText; // "Are You Sure?" metni için
    public Button yesButton; // "Evet" düðmesi için
    public Button noButton; // "Hayýr" düðmesi için

    // Çýkýþ ekranýný açmak için fonksiyon
    public void ShowQuitPanel()
    {
        // UI öðelerini etkinleþtir
        QuitText.gameObject.SetActive(true);
        yesButton.gameObject.SetActive(true);
        noButton.gameObject.SetActive(true);
    }

    // "Evet" düðmesine týklandýðýnda tetiklenir
    public void QuitGame()
    {
        // Uygulamadan çýk
        Application.Quit();
    }

    // "Hayýr" düðmesine týklandýðýnda tetiklenir
    public void CancelExit()
    {
        // Çýkýþ ekranýný kapat
        QuitText.gameObject.SetActive(false);
        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
    }

    // "Quit" düðmesine týklandýðýnda tetiklenir
    public void OnClickQuitButton()
    {
        ShowQuitPanel();
    }
}




