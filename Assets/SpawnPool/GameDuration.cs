using UnityEngine;

public class GameDuration : MonoBehaviour
{
    private float startTime;

    void Start()
    {
        // Store the start time when the game begins
        startTime = Time.time;
    }

    void FixedUpdate()
    {
        // Calculate the game duration
        int gameDuration = GetGameDuration();

        // Log the game duration to the console
        Debug.Log("Game Duration: " + gameDuration + " seconds");
    }

    int GetGameDuration()
    {
        // Get the current time and calculate the duration
        float currentTime = Time.time;
        int duration = Mathf.FloorToInt(currentTime - startTime);
        return duration;
    }
}