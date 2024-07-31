using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
  public void PlayButton()
    {
        SceneManager.LoadScene(2);

    }
        
   public void QuitButton()
    {
        Debug.Log("QUIT");

        Application.Quit();

    }
}
