using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame_Alex : MonoBehaviour
{
    private Animator pauseMenuAnim;
    private bool isPaused;

    private void Start()
    {
        pauseMenuAnim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isPaused)
        {
            pauseMenuAnim.SetTrigger("StartStopAnim");
            Debug.Log("paused");

            Time.timeScale = 0;
            isPaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused)
        {
            pauseMenuAnim.SetTrigger("StartStopAnim");
            Time.timeScale = 1;
            isPaused = false;
            Debug.Log("Unpaused");
        }
    }
}
