using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    private IEnumerator LoadSceneCoroutine()
    {
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene("MainMenu");

        Debug.Log("button clicked");
    }

    public void loadSceneButton()
    {
        StartCoroutine(LoadSceneCoroutine());
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}