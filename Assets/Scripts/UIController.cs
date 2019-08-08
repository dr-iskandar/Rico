using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public string downloadUrl;

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void DownloadMarker()
    {
        Application.OpenURL(downloadUrl);
    }

    public void exit()
    {
        Application.Quit();
    }
}
