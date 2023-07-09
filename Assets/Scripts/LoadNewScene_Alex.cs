using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    public int loadlevel;

    public void loadSceneButton()
    {
        SceneManager.LoadScene("MorningScene");
    }
}