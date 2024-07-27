using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGame : MonoBehaviour
{
    public static bool gameIsPaused = false;


    private void OnEnable()
    {
        gameIsPaused = true;
    }

    private void OnDisable()
    {
        gameIsPaused = false;
    }

    

    void PauseGame()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
