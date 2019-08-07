using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void DownloadMarker()
    {
        Application.OpenURL("https://drive.google.com/uc?authuser=4&id=1hePzMhOWFKzsVxP9PT12oAjyEc8JSnar&export=download");
    }

    public void exit()
    {
        Application.Quit();
    }
}
