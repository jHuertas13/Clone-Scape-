using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextLevel : MonoBehaviour
{
    //public bool Close = true;
    public string LevelToGo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!GetComponent<OpenDoor>().Close)
        {


            Debug.Log("To Next level");
            SceneManager.LoadScene(LevelToGo, LoadSceneMode.Single);
        }
    }

    
}
