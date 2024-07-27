using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{


    public string SceneName;


    public void OnClick()
    {
        SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
    }
}
