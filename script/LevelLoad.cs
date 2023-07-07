using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoad : MonoBehaviour
{
    public GameObject loadingPanel;
    public Text loadingText;
    public GameObject cutsceneCam;


    public void LoadLevel (string levelName)
    {
        loadingPanel.SetActive(true);
        StartCoroutine(LoadSceneAsync(levelName));
        
    }

    private IEnumerator LoadSceneAsync ( string levelName )
    {
        

        AsyncOperation op = SceneManager.LoadSceneAsync(levelName);


        cutsceneCam.SetActive(true);
        yield return null;           
        
    }
}
