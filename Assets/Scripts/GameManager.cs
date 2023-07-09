using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // Add your variables here
    public int currentDay = 1;
    public int health = 10;
    public int stress = 10;
    public int energy = 10;
    public int academicAbilty = 10;
    public float budget = 50.00f;
    public bool hasEaten = false;

    public int healthy1 = 0;
    public int healthy2 = 0;
    public int healthy3 = 0;
    public int mid1 = 0;
    public int mid2 = 0;
    public int mid3 = 0;
    public int unhealthy1 = 0;
    public int unhealthy2 = 0;
    public int unhealthy3 = 0;

    public Dictionary<string, int> meals = new Dictionary<string, int>();

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

}
