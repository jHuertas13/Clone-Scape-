using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class selectLevel : MonoBehaviour
{
    private AssetBundle myLoadedAssetBundle;
    public string[] scenePaths;
    public int sceneToOpenIndex;

    private void Start()
    {
        myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/AssetBundles/scenes");
        scenePaths = myLoadedAssetBundle.GetAllScenePaths();
    }
    private void OnMouseDown()
    {
        SceneManager.LoadScene(scenePaths[sceneToOpenIndex], LoadSceneMode.Additive);
    } 

}
