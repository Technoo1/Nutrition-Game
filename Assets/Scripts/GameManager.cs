using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // Add your variables here
    public int health = 10;
    public int stress = 10;
    public int energy = 10;
    public int academicAbilty = 10;
    public float budget = 50.00f;
    public bool hasEaten = false;
    private void Awake()
    {
        // Ensure only one instance of the GameManager exists
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Add your methods and functionality here
    public void Study()
    {
        GameManager.instance.academicAbilty += 10;
        Debug.Log("+10 to academic ability");
        Debug.Log("Your academic ability is: " + academicAbilty);
    }
    public void Relax()
    {
        GameManager.instance.stress -= 10;
        GameManager.instance.energy += 10;
        Debug.Log("-10 to stress");
        Debug.Log("Your stress is " + stress);
        Debug.Log("+10 to energy");
        Debug.Log("Your energy is " + energy);
    }
}
