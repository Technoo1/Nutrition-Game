using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatDisplay : MonoBehaviour
{
    public TextMeshProUGUI currentDay;
    public TextMeshProUGUI money;
    public TextMeshProUGUI health;
    public TextMeshProUGUI stress;
    public TextMeshProUGUI energy;
    public TextMeshProUGUI academic;
    public TextMeshProUGUI leftovers;
    public TextMeshProUGUI youLose;
    public TextMeshProUGUI youWin;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentDay.text = "Day " + GameManager.instance.currentDay;
        money.text = "Money: $" + GameManager.instance.budget;
        health.text = "Health: " + GameManager.instance.health;
        stress.text = "Stress: " + GameManager.instance.stress;
        energy.text = "Energy: " + GameManager.instance.energy;
        academic.text = "Academic " + GameManager.instance.academicAbilty;
        leftovers.text = "Leftovers " + (GameManager.instance.healthy1 + GameManager.instance.healthy2
            + GameManager.instance.healthy3 + GameManager.instance.mid1 + GameManager.instance.mid2 +
            GameManager.instance.mid3 + GameManager.instance.unhealthy1 + GameManager.instance.unhealthy2
            + GameManager.instance.unhealthy3);
    }
}
