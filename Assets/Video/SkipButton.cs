using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class SkipButton : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public Button skipButton;

    void Start()
    {
        videoPlayer.loopPointReached += EndReached;
        skipButton.onClick.AddListener(SkipVideo);
        skipButton.gameObject.SetActive(true);
    }

    void EndReached(VideoPlayer vp)
    {
        LoadNextScene();
    }

    public void SkipVideo()
    {
        videoPlayer.Stop();
        LoadNextScene();
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
