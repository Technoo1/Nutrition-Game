using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    public int loadlevel;

    private IEnumerator LoadSceneCoroutine()
    {
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(loadlevel);
    }

    public void loadSceneButton()
    {
        StartCoroutine(LoadSceneCoroutine());
    }
}