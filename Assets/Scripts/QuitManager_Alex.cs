using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitManager_Alex : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("quit");

        Time.timeScale = 1;
    }
}
