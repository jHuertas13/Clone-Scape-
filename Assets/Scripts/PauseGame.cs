using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public static bool gameIsPaused = false;
    private void OnEnable()
    {
        Pause();
    }

    private void OnDisable()
    {
        Pause();
    }
    void Pause()
    {
        if (!gameIsPaused)
        {
            Time.timeScale = 0f;
            Debug.Log("Pause");
            gameIsPaused = !gameIsPaused;
        }
        else
        {
            Time.timeScale = 1;
            Debug.Log("going");
            gameIsPaused = !gameIsPaused;
        }

    }
}
